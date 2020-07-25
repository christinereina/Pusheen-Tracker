using System.Collections.Generic;

namespace PusheenTracker.Models
{
  public class Order
  {
    public string OrderType { get; set; }

    public int OrderQuantity { get; set; }

    public int OrderPrice { get; set; }

    public int Id { get; }

    public List<Vendor> Vendors { get; set; }
    private static List<Order> _orderDetails = new List<Order>{};

    public Order(string orderType, int orderQuantity)
      : this(orderType)
    {
      OrderQuantity = orderQuantity;
    }

     public Order(string orderType, int orderQuantity, int orderPrice)
      : this(orderType, orderQuantity)
    {
     OrderPrice = orderPrice;
    }

      public Order(string orderType)
    {
      OrderType = orderType;
      _orderDetails.Add(this);
      Id = _orderDetails.Count;
      Vendors = new List<Vendor> {};
    }
     public static void ClearAll()
    {
      _orderDetails.Clear();
    }
 
  }
}
