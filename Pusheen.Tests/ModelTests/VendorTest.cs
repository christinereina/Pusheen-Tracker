using Microsoft.VisualStudio.TestTools.UnitTesting;
using PusheenTracker.Models;
using System;
using System.Collections.Generic;

namespace PusheenTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

     public void Dispose()
    {
      Vendor.ClearAll();
    }
    
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

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string name = "Tour de Jours";
      Vendor createVendor = new Vendor(name);
      int result = createVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyVendorList_VendorList()
    {
    List<Vendor> newList = new List<Vendor> { };
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor vendorOne = new Vendor("Tour de Jours");
      Vendor vendorTwo = new Vendor("Mo-Mo");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendorTwo , result);
    }

  }
  
}