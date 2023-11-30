using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApp.Models;

namespace FormApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index(string searchString)
    {
        var products = Repository.Products;

        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            products = Repository.Products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }

        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
