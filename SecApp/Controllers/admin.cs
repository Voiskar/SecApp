using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
