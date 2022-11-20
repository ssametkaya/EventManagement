using DataAccessLayer.Concrete;
using EventManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementWeb.ViewComponents.City
{
    public class HomePageCityList : ViewComponent
    {
        private readonly AppDbContext _appDbContext;
        public HomePageCityList(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _appDbContext.Cities.Take(4).Select(x => new HomePageCityViewModel()
            {
                ID=x.CityID,
                City=x.Name,
            }).ToList();


            return View(result);
        }
    }
}
