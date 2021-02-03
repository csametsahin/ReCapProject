using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
              new Car{Id=1,BrandId = 1 ,ColorId=2,DailyPrice=10000,ModelYear=2020,Description="Great Car" },
            new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 5000, ModelYear = 1998, Description = "Old Car" },
            new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 50000, ModelYear = 1990, Description = "Great Old Car" },
            new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 500, ModelYear = 2007, Description = "Good Car" },
            new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 10, ModelYear = 2010, Description = "Bad Car" },
        };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
