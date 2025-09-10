using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
