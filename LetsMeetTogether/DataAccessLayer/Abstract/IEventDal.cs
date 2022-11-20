using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEventDal:IGenericDal<Event>
    {
         //Task<List<Event>> GetAllWithCityAsync();
         //Task<List<Event>> GetAllWithCategoryAsync();
    }
}
