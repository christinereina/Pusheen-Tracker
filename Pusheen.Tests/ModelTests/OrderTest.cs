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
      public void OrderConstructor_CreatesInstanceOfOrder_Quantity()
     {
      Order newOrder = new Order("Red Bean Buns", 20 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
     }

     [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Price()
     {
      Order newOrder = new Order("Red Bean Buns", 20, 50 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
     }

    [TestMethod]
    public void GetOrderType_ReturnOrderType_String()
    {
      string orderType = "Green Tea Cloud Cakes";
      Order newOrder = new Order(orderType);
      string result = newOrder.OrderType;
      Assert.AreEqual(orderType, result);
    }

    [TestMethod]
      public void GetProperties_ReturnOrderProperties_String()
    {
      string orderType = "Green Tea Cloud Cakes";
      int orderQuantity = 20;
      int orderPrice = 200;
      Order newOrder = new Order(orderType, orderQuantity, orderPrice);
      string orderTypeResult = newOrder.OrderType;
      int orderQuantityResult = newOrder.OrderQuantity;
      int orderPriceResult = newOrder.OrderPrice;
      Assert.AreEqual(orderType, orderTypeResult);
      Assert.AreEqual(orderQuantity, orderQuantityResult);
      Assert.AreEqual(orderPrice, orderPriceResult);      
    }
  }
}