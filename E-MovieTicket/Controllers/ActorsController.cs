using Microsoft.AspNetCore.Mvc;

namespace E_MovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
