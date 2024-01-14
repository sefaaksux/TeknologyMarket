using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index(string searchString,string category)
    {
        var products = Repository.Products;

        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            products = Repository.Products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }
        
        ViewBag.Categories = new SelectList(Repository.Categories,"CategoryId","Name");
        
        if(!string.IsNullOrEmpty(category) && category != "0")
        {
            ViewBag.searchCategory = category;
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        

        return View(products);
    }


    [HttpGet]
    public IActionResult Createe()
    {
        
        ViewBag.Categories = new SelectList(Repository.Categories,"CategoryId","Name");
        return View();
       
    }

    [HttpPost]
    public IActionResult Createe(Product modell)
    {
        Repository.CreateProduct(modell);
        return RedirectToAction("Index");
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string username, string password)
    {
       if (username == "sefa" && password == "aksu")
        {
            // Doğrulama başarılıysa admin sayfasına yönlendirin.
            return RedirectToAction("Index", "Admin");
        }
        else
        {
            // Doğrulama başarısızsa hata mesajı ile ana sayfaya yönlendirin.
            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View("Create");
        }

    }


    
}
