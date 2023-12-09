using Microsoft.AspNetCore.Mvc;
using ManagementPaket_MVC.Models;

namespace ManagementPaket_MVC.Controllers
{
    public class JenisPaketController : Controller
    {

        public IActionResult Index(string pak_id_jenis)
        {
            ViewBag.pak_id_jenis = pak_id_jenis;

            return View();
        }
        public IActionResult CreateJenisPaket()
        {
            return View();
        }
        public IActionResult UpdateJenisPaket(string pak_id_jenis)
        {
            ViewBag.pak_id_jenis = pak_id_jenis;
            return View();

        }


        public IActionResult DetailJenisPaket(string pak_id_jenis)
        {

            return View();
        }


    }
}
