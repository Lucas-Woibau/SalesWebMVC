using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
