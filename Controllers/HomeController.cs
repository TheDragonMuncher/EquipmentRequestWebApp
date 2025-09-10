using Microsoft.AspNetCore.Mvc;
using Assignment1.models;

namespace Assignment1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RequestForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RequestFrom(EquipmentRequestModel request)
    {
        Repository.AddRequest(request);
        return View();
    }
}
