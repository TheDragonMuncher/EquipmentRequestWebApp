using System.Diagnostics;
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
}
