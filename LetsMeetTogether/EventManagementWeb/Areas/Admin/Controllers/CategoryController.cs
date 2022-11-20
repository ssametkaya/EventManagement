using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EventManagementWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EventManagementWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CategoryController(AppDbContext context)
        {
            _appDbContext=context;
        }

        public IActionResult Index()
        {
           var result= _appDbContext.Categories.Select(x => new AdminCategoryViewModel() 
            {
                ID=x.CategoryID,
                Category=x.Name,
            }).ToList();
            return View(result);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(AdminCategoryViewModel request)
        {
            var result = _appDbContext.Categories.Find(request.ID);
            _appDbContext.Remove(result);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Category");
        }


        public IActionResult CategoryDetail(int id)
        {
            var result = _appDbContext.Categories.FirstOrDefault(x => x.CategoryID == id);
            return View("CategoryDetail", result);
        }

        [HttpPost]
        public IActionResult CategoryDetail(Category request)
        {
            _appDbContext.Categories.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category request)
        {
            _appDbContext.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToRoute("/Admin/Category/Index");
        }
    }
}
