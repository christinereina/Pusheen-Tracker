using System.Collections.Generic;

namespace PusheenTracker.Models
{
  public class Order
  {
    public string OrderType { get; set; }

    public string OrderQuantity { get; set; }

    public int OrderPrice { get; set; }

    public int Id { get; }

    private static List<Order> _orderDetails = new List<Order>{};

    public Order(string orderType)
    {
      OrderType = orderType;
      _orderDetails.Add(this);
      Id = _orderDetails.Count;
    }

    public Order(string orderType, string orderQuantity)
      : this(orderType)
    {
      OrderQuantity = orderQuantity;
    }

     public Order(string orderType, string orderQuantity, int orderPrice)
      : this(orderType, orderQuantity)
    {
     OrderPrice = orderPrice;
    }
 
  }
}
