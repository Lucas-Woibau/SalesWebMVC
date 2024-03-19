using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index() //controller
        {
            var list = _sellerService.FindAll(); //model
            return View(list); //view
        }
    }
}
