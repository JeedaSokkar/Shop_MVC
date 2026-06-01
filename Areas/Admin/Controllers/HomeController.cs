using Microsoft.AspNetCore.Mvc;

namespace ShopMvc.Admin.Controllers
{
  [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
