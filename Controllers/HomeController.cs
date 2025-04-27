using Microsoft.AspNetCore.Mvc;
namespace PersonManagementApp.Controllers;

public class HomeController : Controller
{
    public RedirectResult Index()
    {
        return Redirect("/persons");
    }
}
