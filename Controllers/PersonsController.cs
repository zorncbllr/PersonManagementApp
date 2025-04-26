using Microsoft.AspNetCore.Mvc;

namespace PersonManagementApp.Controllers;

[Route("Persons")]
public class PersonsController : Controller
{
    [HttpGet()]
    public IActionResult GetAllPersons()
    {
        return Content("Persons");
    }
}