using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using System.Collections.Generic;
using SAL;
using BOL;

namespace EStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
        ProductHubService svc=new ProductHubService();
        List<Product> allProducts=svc.GetAllProducts();
        this.ViewData["products"]=allProducts;
        this.ViewBag.catelog=allProducts;
        return View();
    }

    //http://localhost:7654/products/details/45
    [HttpGet]
    public IActionResult Details(String id)
    {
        ProductHubService svc=new ProductHubService();
        Product product=svc.GetProductById(id);
        Console.WriteLine(product.Title + " " + product.ProductId);
        this.ViewBag.currentProduct=product;
        return View();
        
    }

     
}
