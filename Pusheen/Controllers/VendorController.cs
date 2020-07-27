using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PusheenTracker.Models;


namespace PusheenTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor createVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

   [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderType, int orderQuantity, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderType, orderQuantity, orderPrice);
      selectVendor.AddOrder(newOrder);
      List<Order> vendorOrders = selectVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendors", selectVendor);
      return View("Show", model);
    }


  }
}