using Microsoft.AspNetCore.Mvc;

namespace AutoFlow.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
