using Microsoft.AspNetCore.Mvc;
using PusheenTracker.Models;

namespace PusheenTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}