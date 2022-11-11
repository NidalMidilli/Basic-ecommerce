using BusinessLayer.Abstract;
using E_commercetaskUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_commercetaskUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
      
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var result = productService.ListAllProduct();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
