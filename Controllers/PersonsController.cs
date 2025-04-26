using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonManagementApp.Data;
using PersonManagementApp.Models;

namespace PersonManagementApp.Controllers;

[Route("Persons")]
public class PersonsController : Controller
{
    protected readonly MyAppContext _context;

    public PersonsController(MyAppContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public async Task<IActionResult> Index()
    {
        var person = await _context.Persons.ToListAsync<Person>();

        return View(person);
    }

    public IActionResult AddPerson(string FirstName)
    {
        return Content($"FirstName: {FirstName}");
    }
}