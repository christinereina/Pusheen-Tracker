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
      Vendor createVendor = new Vendor("Tour de Jours", "French-Asian");
      Assert.AreEqual(typeof(Vendor), createVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Tour de Jours";
      Vendor createVendor = new Vendor(name, "French-Asian");
      string result = createVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Tour de Jours";
      string description = "TOUS les JOURS has developed into a reputable bakery & café franchise, specializing in French-Asian inspired baked goods, passionately made from the finest ingredients.";
      Vendor createVendor = new Vendor(name, description);
      string result = createVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string name = "Tour de Jours";
      string description = "TOUS les JOURS has developed into a reputable bakery & café franchise, specializing in French-Asian inspired baked goods, passionately made from the finest ingredients.";
      Vendor createVendor = new Vendor(name, description);
      int result = createVendor.Id;
      Assert.AreEqual(1, result);
    }

  }
  
}