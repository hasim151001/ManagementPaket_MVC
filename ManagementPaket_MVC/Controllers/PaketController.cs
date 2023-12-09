using Microsoft.AspNetCore.Mvc;

namespace ManagementPaket_MVC.Controllers
{
    public class PaketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
