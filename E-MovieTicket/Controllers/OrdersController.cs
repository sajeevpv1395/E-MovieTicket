using Microsoft.AspNetCore.Mvc;

namespace E_MovieTicket.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
