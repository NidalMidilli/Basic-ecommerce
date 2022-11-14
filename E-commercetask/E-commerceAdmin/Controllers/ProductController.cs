using BusinessLayer.Abstract;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles ="admin")]
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
            ProductValidator productvalidator = new ProductValidator();
            ValidationResult results = productvalidator.Validate(product);
            if (results.IsValid)
            {
                productService.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
            ProductValidator productvalidator = new ProductValidator();
            ValidationResult results = productvalidator.Validate(product);
            if (results.IsValid)
            {
                productService.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
