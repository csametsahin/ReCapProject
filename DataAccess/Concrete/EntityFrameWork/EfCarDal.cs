using Core.DataAcces.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal :EfEntityRepositoryBase<Car,NewDatabaseContext>,ICarDal
    {
       
        public List<CarDetailDto> GetCarDetails()
        {

            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on  c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                ColorName = co.ColorName,BrandName=b.BrandName,DailyPrice=c.DailyPrice,Description=c.Description
                             };
                return result.ToList();

            }

          


        }
        





    }
}
