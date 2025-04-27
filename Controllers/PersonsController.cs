using Microsoft.AspNetCore.Mvc;
using PersonManagementApp.Models;
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

    [HttpPost]
    public async Task<IActionResult> CreatePerson(
            string firstName,
            string lastName,
            string religion,
            string gender,
            string birthplace,
            DateTime birthDate
        )
    {
        var person = new Person()
        {
            FirstName = firstName,
            LastName = lastName,
            Religion = religion,
            Gender = gender,
            BirthPlace = birthplace,
            DateOfBirth = birthDate
        };

        await _repository.CreatePersonAsync(person);

        return RedirectToAction("Index");
    }
}