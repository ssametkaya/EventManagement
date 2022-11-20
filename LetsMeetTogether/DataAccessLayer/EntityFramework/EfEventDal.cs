using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfEventDal : GenericRepository<Event>, IEventDal
    {
        

        //public async Task<List<Event>> GetAllWithCategoryAsync()
        //{
        //    return await _appDbContext.Events.Include(x => x.Category).ToListAsync();

        //}

        //public async Task<List<Event>> GetAllWithCityAsync()
        //{
        //    return await _appDbContext.Events.Include(x => x.City).ToListAsync();

        //}
    }
}
