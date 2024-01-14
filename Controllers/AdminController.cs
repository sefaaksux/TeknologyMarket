using FormApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormApp.Controllers;
    public class AdminController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(Repository.Categories,"CategoryId","Name");
            return View();
        }
        [HttpPost]
        public IActionResult Index(Product modell)
        {
            if(ModelState.IsValid)
            {
                Repository.CreateProduct(modell);
                return RedirectToAction("Index","Home");
            }

            return View(modell);
        }
         
    


    }
    
