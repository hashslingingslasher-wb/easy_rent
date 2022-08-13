using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EasyRent.Models;

namespace EasyRent.Controllers;
/*
This class controls the user views:
    >Browse
    >Checkout
    >Login
    >Profile
    >Register
*/
public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }
    public IActionResult Browse()
    {
        return View();
    }
    public IActionResult Checkout()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
