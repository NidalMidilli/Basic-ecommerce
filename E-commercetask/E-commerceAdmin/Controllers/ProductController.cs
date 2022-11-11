using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Runtime.CompilerServices;

namespace E_commerceAdmin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        Context con = new Context();
        public ProductController(IProductService productService)
        {
           this.productService = productService;
        }
        public IActionResult Index()
        {
            var result = productService.ListAllProduct();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            var result = productService.AddProduct(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = productService.GetById(id);
            return View(result);

        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = con.Products.FirstOrDefault(x => x.productId == id);
            productService.DeleteProduct(result);
            return RedirectToAction("Index");
        }

    }
}
