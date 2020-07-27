using Microsoft.VisualStudio.TestTools.UnitTesting;
using PusheenTracker.Models;
using System;
using System.Collections.Generic;

namespace PusheenTracker.Tests
{

 [TestClass]
  public class OrderTest : IDisposable
  { 
    public void Dispose()
    {
      Order.ClearAll();
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
      string type = "Green Tea Cloud Cakes";
      Order newOrder = new Order(type, 4, 5);
      string result = newOrder.Type;
      Assert.AreEqual(type, result);
    }

    [TestMethod]
      public void GetProperties_ReturnOrderProperties_String()
    {
      string orderType = "Green Tea Cloud Cakes";
      int orderQuantity = 20;
      int orderPrice = 200;
      Order newOrder = new Order(orderType, orderQuantity, orderPrice);
      string orderTypeResult = newOrder.Type;
      int orderQuantityResult = newOrder.Quantity;
      int orderPriceResult = newOrder.Price;
      Assert.AreEqual(orderType, orderTypeResult);
      Assert.AreEqual(orderQuantity, orderQuantityResult);
      Assert.AreEqual(orderPrice, orderPriceResult);      
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
    Order newOrder = new Order("Red Bean Buns", 20, 50 );
    int result = newOrder.Id;
    Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      Order newOrder1 = new Order("Red Bean Buns", 20, 50 );
      Order newOrder2 = new Order("Green Tea Cloud Cakes", 5, 99);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrderObject_Order()
    {
      Order newOrder1 = new Order("Red Bean Buns", 20, 50 );
      Order newOrder2 = new Order("Green Tea Cloud Cakes", 5, 99);
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder1, result);
    }

  }
}