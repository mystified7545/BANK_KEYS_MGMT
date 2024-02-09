using Microsoft.AspNetCore.Mvc;

namespace BANK_KEYS_MGMT.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NFTLanding()
        {
            return View();
        }

        public IActionResult Job()
        {
            return View();
        }
    }
}
