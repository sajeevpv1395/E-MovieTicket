using Microsoft.AspNetCore.Mvc;

namespace E_MovieTicket.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
