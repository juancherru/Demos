using Microsoft.AspNetCore.Mvc;

namespace MusicStoreMVC.Controllers
{
public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}

}