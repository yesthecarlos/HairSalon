using Microsoft.AspNetCore.Mvc;

namespace EauClaire.Controllers
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