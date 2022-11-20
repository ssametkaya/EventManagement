using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public List<City> GetAll()
        {
           return _cityDal.GetAll();
        }

        public City GetById(int id)
        {
            return _cityDal.GetByID(id);
        }

        public void TAdd(City entity)
        {
            _cityDal.Insert(entity);
        }

        public void TRemove(City entity)
        {
            _cityDal.Delete(entity);
        }

        public void TUpdate(City entity)
        {
            _cityDal.Update(entity);
        }
    }
}
