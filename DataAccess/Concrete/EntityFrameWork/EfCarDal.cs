using Core.DataAcces.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
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
        
    }
}
