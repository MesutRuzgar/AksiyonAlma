using AksiyonAlma.Models;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AksiyonAlma.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        
    }
}