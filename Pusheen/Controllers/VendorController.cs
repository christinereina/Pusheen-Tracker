using Microsoft.AspNetCore.Mvc;
using PusheenTracker.Models;
using System.Collections.Generic;
using System;

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

  }
}