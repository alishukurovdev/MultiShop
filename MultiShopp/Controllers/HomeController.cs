using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MultiShopp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return new ViewResult();
        }
        public async Task<IActionResult> Contact()
        {
            return new ViewResult();
        }
    }
}
