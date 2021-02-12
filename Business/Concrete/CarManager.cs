using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if(car.Description.Length<2 || car.DailyPrice <= 0)
            {
                return new ErrorResult("Araba Açıklaması 2 den küçük olamaz veya günlük fiyatı 0 dan küçük olamaz");
            }
            else
            {
                _carDal.Add(car);
                return new SuccessResult("Araba başarıyla eklendi");
            }
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araba başarıyla silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Araba Listesi Başarıyla Elde Edildi");
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araba başarıyla güncellendi");
        }
    }
}
