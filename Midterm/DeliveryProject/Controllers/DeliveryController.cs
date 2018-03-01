using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using DataLibrary.Models;
using DataLibrary;
using DeliveryProject.Models;

namespace DeliveryProject.Controllers
{
    public class DeliveryController : Controller
    {
        private DeliveryMarket dc;
        
        public DeliveryController()
        {
           dc = new DeliveryMarket();
        }
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            var orders = dc.GetOrder();
            return View(orders);
        }

        public IActionResult Road()
        {
            var records = dc.GetRoad();
            ViewData["Message"] = "Your contact page.";

            return View(records);
        }

        public IActionResult Category()
        {
            var categories = dc.GetCategory();
            ViewData["Message"] = "Your contact page.";

            return View(categories);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
