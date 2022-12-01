using Microsoft.AspNetCore.Mvc;

namespace E_MovieTicket.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
