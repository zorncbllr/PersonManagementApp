using Microsoft.AspNetCore.Mvc;
using PersonManagementApp.Repositories;

namespace PersonManagementApp.Controllers;

[Route("persons")]
public class PersonsController : Controller
{
    private readonly PersonRepository _repository;

    public PersonsController(PersonRepository personRepository)
    {
        _repository = personRepository;
    }

    public ViewResult Index()
    {
        return View();
    }
}