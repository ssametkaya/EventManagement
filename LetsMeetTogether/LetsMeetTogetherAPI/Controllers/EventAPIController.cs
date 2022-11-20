using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace LetsMeetTogetherAPI.Controllers
{
    public class EventAPIController : Controller
    {
        private readonly AppDbContext _context;


        public EventAPIController(AppDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult GetEvents()
        //{
        //    var result = _context.Events.Include(x => x.Category).Include(x => x.City)
        //                .Select(a => new EventAPIViewModel()
        //                {
        //                    EventId=a.EventID,
        //                    Name=a.EventName,
        //                    Description=a.Description,
        //                    Capacity=a.Capacity,
        //                    City=a.City.Name,
        //                    Category=a.Category.Name,
        //                    Date=a.Date,
        //                    ClosedDate=a.ClosedDate,
        //                });
        //    return Ok(result);
        //}

    }
}