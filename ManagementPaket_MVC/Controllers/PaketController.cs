using Microsoft.AspNetCore.Mvc;

namespace ManagementPaket_MVC.Controllers
{
    public class PaketController : Controller
    {
        public IActionResult Index(int pak_id)
        {
            ViewBag.pak_id = pak_id;

            return View();
        }

    }
}
