using Microsoft.VisualStudio.TestTools.UnitTesting;
using PusheenTracker.Models;
using System;
using System.Collections.Generic;

namespace PusheenTracker.Tests
{
  [TestClass]
  public class AlbumTests
  {
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor createVendor = new Vendor("Tour de Jours");
      Assert.AreEqual(typeof(Vendor), createVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Tour de Jours";
      Vendor createVendor = new Vendor(name);
      string result = createVendor.Name;
      Assert.AreEqual(name, result);
    }

  }
  
}