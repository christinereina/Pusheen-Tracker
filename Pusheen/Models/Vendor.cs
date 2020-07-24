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
    
  }
}
