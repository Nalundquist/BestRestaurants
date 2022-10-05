using Miscrosoft.AspNetCore.Mvc;

namespace BestRestaurants.Controllers
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