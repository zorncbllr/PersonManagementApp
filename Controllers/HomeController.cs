using Microsoft.AspNetCore.Mvc;
namespace PersonManagementApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("Home");
    }
}
