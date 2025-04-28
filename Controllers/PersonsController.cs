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
    [ValidateAntiForgeryToken]
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

    [HttpPost("delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeletePerson(int PersonId)
    {
        await _repository.DeletePersonAsync(PersonId);

        return RedirectToAction("Index");
    }
}