using Microsoft.AspNetCore.Mvc;

namespace PreTestAXA.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
