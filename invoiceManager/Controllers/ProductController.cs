using Microsoft.AspNetCore.Mvc;

namespace invoiceManager.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
