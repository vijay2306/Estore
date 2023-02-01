using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using System.Collections.Generic;
using SAL;
using BOL;

namespace EStore.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<DepartmentController> _logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
        DepartmentHubService svc=new DepartmentHubService();
        List< Department> allDepartments=svc. GetAllDepartments();
        
        this.ViewData["department"]=allDepartments;
        //this.ViewBag.catelog=allProducts;
        return View();
    }


     
}
