using Microsoft.AspNetCore.Mvc;
using FastEquipment.Models;
using FastEquipment.Models.DataHandling;

namespace FastEquipment.Controllers;

public class HomeController : Controller
{
    private IEquipmentRepository equipmentRepository;
    private IEquipmentRequestRepository equipmentRequestRepository;
    public HomeController(IEquipmentRepository er, IEquipmentRequestRepository err)
    {
        equipmentRepository = er;
        equipmentRequestRepository = err;
    }
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
    public ViewResult RequestForm(EquipmentRequest request)
    {
        if (ModelState.IsValid) // validation
        {
            // request.GiveId();
            equipmentRequestRepository.Add(request);
            equipmentRepository.Update();
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
        return View(equipmentRepository.GetAll());
    }
    public ViewResult AvailableEquipment()
    {
        return View(equipmentRepository.GetAvailable());
    }

    // admin view
    public ViewResult Requests()
    {
        return View(equipmentRequestRepository.GetAll());
    }
}
