using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EventManagementWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EventManagementWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public EventController(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IActionResult Events()
        {
            var result = _appDbContext.Events.Include(x => x.Category).Include(x => x.City).Select(x => new EventViewModel()
            {
                ID = x.EventID,
                Name = x.EventName,
                Category = x.Category.Name,
                City = x.City.Name,
                DateTime = x.Date,
                Description = x.Description,
                EventCapacity = x.Capacity,

            }).ToList();
            return View(result);
        }

        public IActionResult EventDetail(int id)
        {
            var result = _appDbContext.Events.Include(x=>x.Category).Include(x=>x.City).FirstOrDefault(x=>x.EventID == id);
            return View("EventDetail", result);
        }

        [HttpPost]
        public IActionResult EventDetail(Event request)
        {
            _appDbContext.Events.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult DeleteEvent(int id)
        {
            var result = _appDbContext.Events.Find(id);
            _appDbContext.Remove(result);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Event");
        }

    }
}
