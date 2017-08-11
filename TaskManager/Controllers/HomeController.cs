using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Products()
        {
            
            var products = new List<Product>();

            products.Add(new Product()
            {
                Title = "Cola",
                Amount = 24
            });
            products.Add(new Product()
            {
                Title = "Sprite",
                Amount = 12
            });
            products.Add(new Product()
            {
                Title = "Fanta",
                Amount = 21
            });
            
            return View(products);            
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
