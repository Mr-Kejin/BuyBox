using BuyBox.DataAccess.Data;
using BuyBox.DataAccess.Repository.IRepository;
using BuyBox.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyBox.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _CategoryRespo;
        public CategoryController(ICategoryRepository db)
        {
            _CategoryRespo = db;
        }

        public IActionResult Index()
        {       
            List <Category> objCategoryList = _CategoryRespo.GetAll().ToList(); 
            return View(objCategoryList);            
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {           
            if (ModelState.IsValid)
            {
                _CategoryRespo.Add(obj);
                _CategoryRespo.save();
                TempData["Success"] = "category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id==null || id == 0)
            {
                return NotFound();
            }
            // Category? categoryFromDb = _db.Categories.Find(id);
            Category? categoryFromDb = _CategoryRespo.Get(u => u.Id == id);
            if (categoryFromDb == null) 
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _CategoryRespo.Update(obj);
                _CategoryRespo.save();
                TempData["Success"] = "category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _CategoryRespo.Get(u => u.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _CategoryRespo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _CategoryRespo.Remove(obj);
            _CategoryRespo.save();
            TempData["Success"] = "category Deleted successfully";
            return RedirectToAction("Index");

            
        }
    }
}
