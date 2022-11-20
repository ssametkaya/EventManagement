using Microsoft.AspNetCore.Mvc;

namespace EventManagementWeb.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
