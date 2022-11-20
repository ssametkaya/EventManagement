using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EventManagementWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EventManagementWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CityController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CityController(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IActionResult Index()
        {
            var result = _appDbContext.Cities.Select(x => new AdminCityViewModel()
            {
                ID = x.CityID,
                City = x.Name,
            }).ToList();
            return View(result);

        }

        public IActionResult CityDetail(int id)
        {
            var result = _appDbContext.Cities.FirstOrDefault(x => x.CityID == id);
            return View("CityDetail", result);
        }

        [HttpPost]
        public IActionResult CityDetail(City request)
        {
            _appDbContext.Cities.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult DeleteCity(int id)
        {
            var result = _appDbContext.Cities.Find(id);
            _appDbContext.Remove(result);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "City");
        }

        [HttpGet]
        public IActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCity(City request)
        {
            _appDbContext.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "City");
        }
    }
}
