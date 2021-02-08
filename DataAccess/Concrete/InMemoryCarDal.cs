using DataAccess.Abstract;
using Entities.Concrete;
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
              new Car{CarId=1,BrandId = 1 ,ColorId=2,DailyPrice=10000,ModelYear=2020,Description="Great Car" },
            new Car { CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 5000, ModelYear = 1998, Description = "Old Car" },
            new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 50000, ModelYear = 1990, Description = "Great Old Car" },
            new Car { CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 500, ModelYear = 2007, Description = "Good Car" },
            new Car { CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 10, ModelYear = 2010, Description = "Bad Car" },
        };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
