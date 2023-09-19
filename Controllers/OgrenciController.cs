using Microsoft.AspNetCore.Mvc;

namespace EfCoreKursApp.Controllers
{
    public class OgrenciControllers : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}