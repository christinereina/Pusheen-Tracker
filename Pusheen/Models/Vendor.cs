using System.Collections.Generic;

namespace PusheenTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int Id { get; }
    private static List<Vendor> _vendorList = new List<Vendor> {};

    public Vendor(string name)
    {
      Name = "";
      _vendorList.Add(this);
      Id = _vendorList.Count;
    }
    
  }
}
