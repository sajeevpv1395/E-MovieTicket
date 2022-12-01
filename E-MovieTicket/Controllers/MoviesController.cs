using Microsoft.AspNetCore.Mvc;

namespace E_MovieTicket.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
