using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_commerceAdmin.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService categoryService;
        Context con = new Context();
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var result = categoryService.ListAllCategory();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            var result = categoryService.AddCategory(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = categoryService.GetById(id);
            return View(result);

        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = con.Categories.FirstOrDefault(x => x.categoryId == id);
            categoryService.DeleteCategory(result);
            return RedirectToAction("Index");
        }
      
    }
}
