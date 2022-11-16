using BusinessLayer.Abstract;
using E_commercetaskUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commercetaskUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService) { 
            this.productService = productService;
        }
        public IActionResult Index() {
            ProductListViewModel model = new ProductListViewModel {

                Products = productService.ListAllProduct()
        };
            return View(model);
        }
    }
}
