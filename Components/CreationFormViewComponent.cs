using Microsoft.AspNetCore.Mvc;

namespace PersonManagementApp.Components;

public class CreationFormViewComponent : ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
}