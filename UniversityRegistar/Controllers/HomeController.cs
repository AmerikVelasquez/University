using Microsoft.AspNetCore.Mvc;

namespace UniversityRegistar.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}