using Microsoft.AspNetCore.Mvc;
namespace PersonManagementApp.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }
}
