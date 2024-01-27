using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            List<Category> categories = categoryRepository.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            /* if (category.Name == category.DisplayOrder)
             {
                 ModelState.AddModelError("name", "Name and Order cannot be same");
             }*/
            if (ModelState.IsValid)
            {
                categoryRepository.Add(category);
                categoryRepository.Save();
                TempData["success"] = "Category Created Successfully.";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id != null && id != 0)
            {
                Category? categoryDb = categoryRepository.Get(c => c.Id == id);
                if (categoryDb != null)
                {
                    return View(categoryDb);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                  categoryRepository.Update(category);
                    categoryRepository.Save();
                TempData["success"] = "Category Updated Successfully.";
                return RedirectToAction("Index");
     
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                Category? categoryDb = categoryRepository.Get(c => c.Id == id);
                if (categoryDb != null)
                {
                    return View(categoryDb);
                }
            }
            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteAPI(int? id)
        {
            if (id != null && id != 0)
            {
                Category? categoryDb = categoryRepository.Get(c => c.Id == id);
                if (categoryDb != null)
                {
                    categoryRepository.Remove(categoryDb);
                    categoryRepository.Save();
                    TempData["success"] = "Category Deleted Successfully.";
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
