using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 1)
            {
              return new ErrorResult("Brand ismi 1 harften oluşamaz");
            }
            else
            {
                _brandDal.Add(brand);
               return new SuccessResult("Brand başarıyla Eklendi");
            }
            
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Brand başarıyla silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Brand Listesi Başarıyla Alındı");

        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Brand başarıyla update edildi");
        }
    }
}
