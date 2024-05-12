using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult All() 
        {
            //RazorPage<>
                
            ProductBusinessLayer productBusinessLayer = new ProductBusinessLayer();
            return View("showAll" , productBusinessLayer.GetProducts());
        }
        
        public IActionResult Details(int id)  
        {
            ProductBusinessLayer productBusinessLayer = new ProductBusinessLayer();
            return View("Details", productBusinessLayer.GetProducts().Where(p => p.Id == id).First());
        }
    }
}
