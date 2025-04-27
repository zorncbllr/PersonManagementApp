using Microsoft.AspNetCore.Mvc;
using PersonManagementApp.Repositories;

namespace PersonManagementApp.Components;

public class TableViewComponent : ViewComponent
{

    private readonly PersonRepository _repository;

    public TableViewComponent(PersonRepository repository)
    {
        _repository = repository;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var persons = await _repository.GetAllPersonsAsync();

        return View(persons);
    }
}