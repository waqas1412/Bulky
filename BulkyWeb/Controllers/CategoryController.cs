using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = dbContext.Categories.ToList();
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
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id != null && id != 0)
            {
                Category? categoryDb = dbContext.Categories.FirstOrDefault(c => c.Id == id);
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
                  dbContext.Update(category);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
     
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                Category? categoryDb = dbContext.Categories.FirstOrDefault(c => c.Id == id);
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
                Category? categoryDb = dbContext.Categories.FirstOrDefault(c => c.Id == id);
                if (categoryDb != null)
                {
                    dbContext.Remove(categoryDb);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
