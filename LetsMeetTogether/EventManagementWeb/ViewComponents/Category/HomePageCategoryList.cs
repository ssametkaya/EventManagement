using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EventManagementWeb.Models;
using DataAccessLayer.Concrete;

namespace EventManagementWeb.ViewComponents.Category
{
    public class HomePageCategoryList : ViewComponent
    {
        //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        private readonly AppDbContext _appDbContext;
        public HomePageCategoryList(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _appDbContext.Categories.Take(3).Select(x => new HomePageCategoryViewModel()
            {
                ID = x.CategoryID,
                Category = x.Name,

            }).ToList();

            
            return View(result);
        }

    }

}
