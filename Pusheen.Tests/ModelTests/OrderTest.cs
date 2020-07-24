using Microsoft.VisualStudio.TestTools.UnitTesting;
using PusheenTracker.Models;
using System;
using System.Collections.Generic;

namespace PusheenTracker.Tests
{

 [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("5 red bean buns");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

     [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Price()
     {
      Order newOrder = new Order("Red Bean Buns", 20, 50 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
     }
  }

}