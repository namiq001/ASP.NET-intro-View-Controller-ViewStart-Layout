using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_intro.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
}
