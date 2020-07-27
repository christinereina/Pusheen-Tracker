using Microsoft.AspNetCore.Mvc;
using PusheenTracker.Models;
using System.Collections.Generic;

namespace PusheenTracker.Controllers
{
  public class OrdersController : Controller
  {
     [HttpGet("/vendors/{vendorId}/orders/new")]
      public ActionResult New(int vendorId)
      {
       Vendor chooseVendor = Vendor.Find(vendorId);
      return View(chooseVendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order chooseOrder = Order.Find(orderId);
      Vendor chooseVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", chooseOrder);
      model.Add("vendor", chooseVendor);
      return View(model);
      
    }
  }
}