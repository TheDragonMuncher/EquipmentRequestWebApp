using Microsoft.AspNetCore.Mvc;
using FastEquipment.Models;

namespace FastEquipment.Controllers;

public class HomeController : Controller
{
    // home view
    public IActionResult Index()
    {
        return View();
    }

    // view for default request form
    [HttpGet]
    public ViewResult RequestForm()
    {
        return View();
    }

    // view for submitting request form data 
    [HttpPost]
    public ViewResult RequestForm(EquipmentRequestModel request)
    {
        if (ModelState.IsValid) // validation
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

    // views for displaying tables of equipment
    public ViewResult AllEquipment()
    {
        return View(Repository.Equipment);
    }
    public ViewResult AvailableEquipment()
    {
        return View(Repository.Equipment.Where(e => e.available == true));
    }

    // admin view
    public ViewResult Requests()
    {
        return View(Repository.Requests);
    }
}
