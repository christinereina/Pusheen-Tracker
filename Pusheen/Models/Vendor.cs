using System.Collections.Generic;

namespace PusheenTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }

    public string Description { get; set; }

    public int Id { get; set;}
    private static List<Vendor> _vendorList = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
    }

      public static void ClearAll()
    {
      _vendorList.Clear();
    }

      public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

     public static Vendor Find(int searchId)
    {
      return _vendorList[searchId - 1];
    }
    
  }
}
