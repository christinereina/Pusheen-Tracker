using System.Collections.Generic;

namespace PusheenTracker.Models
{
  public class Order
  {
    public string Type { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public int Id { get; }

    private static List<Order> _instances = new List<Order>{ };

      public Order(string type, int quantity, int price)
    {
      Type = type;
      Quantity = quantity;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }
     public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order FindOrder(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}
