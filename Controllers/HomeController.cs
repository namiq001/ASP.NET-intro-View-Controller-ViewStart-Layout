using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_intro.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); 
    }
}
