using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

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
    public ViewResult RequestForm(EquipmentRequestModel request)
    {
        if (ModelState.IsValid)
        {
            request.GiveId();
            Repository.AddRequest(request);
            return View("RequestConfirmation", request);
        }
        else
        {
            return View();
        }
    }

    public ViewResult AllEquipment()
    {
        return View(Repository.Equipment);
    }
    public ViewResult AvailableEquipment()
    {
        return View(Repository.Equipment.Where(e => e.available == true));
    }
}
