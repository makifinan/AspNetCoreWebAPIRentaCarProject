using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
  public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear=2010,DailyPrice=200,Description="yakıt cimrisi"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2012,DailyPrice=250,Description="Öneri Aracı"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2014,DailyPrice=280,Description="Fırsat aracı"},
                new Car{Id=4,BrandId=4,ColorId=1,ModelYear=2016,DailyPrice=320,Description="Uygun araç"},
                new Car{Id=5,BrandId=5,ColorId=4,ModelYear=2017,DailyPrice=400,Description="Konforlu araç"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToBeDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToBeDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.BrandId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToBeUpdated = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToBeUpdated.ColorId = car.ColorId;
            carToBeUpdated.BrandId = car.BrandId;
            carToBeUpdated.DailyPrice = car.DailyPrice;
            carToBeUpdated.Description = car.Description;
            carToBeUpdated.ModelYear = car.ModelYear;

        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
  