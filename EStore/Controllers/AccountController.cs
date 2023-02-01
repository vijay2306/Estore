using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;

namespace EStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Login(String email,String password)
    {

        if(email=="vijaysharma@gmail.com" && password=="4545")
        {

            Response.Redirect("/orders/index");
        }
        return View();
    
    }
    [HttpPost]
    public IActionResult Register(String firstname,String lastname,String email)
    {
        Console.WriteLine(firstname+" "+lastname+" "+email);
         return this.RedirectToAction("Login","Account");
        
    }
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
