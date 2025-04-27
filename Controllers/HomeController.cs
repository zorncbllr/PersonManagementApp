using Microsoft.AspNetCore.Mvc;
using PersonManagementApp.Repositories;
namespace PersonManagementApp.Controllers;

public class HomeController : Controller
{
    private readonly PersonRepository _personRepository;

    public HomeController(PersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public IActionResult Index()
    {
        return Redirect("/persons");
    }
}
