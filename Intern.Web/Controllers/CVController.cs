using Microsoft.AspNetCore.Mvc;

namespace Intern.Web.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
