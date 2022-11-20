using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EventManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManagementWeb.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public EventController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var result=_appDbContext.Events.Include(x=>x.Category).Include(x=>x.City).Select(x => new EventViewModel()
            {
                ID=x.EventID,
                Name=x.EventName,
                Category=x.Category.Name,
                City=x.City.Name,
                DateTime=x.Date,
                Description=x.Description,
                EventCapacity=x.Capacity,

            }).ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEvent(Event request)
        {
            _appDbContext.Add(request);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index","Event");
        }

        
    }
}
