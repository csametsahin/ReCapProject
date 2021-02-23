using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=> c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2000).When(c => c.BrandId==0);
            //olmayan bir metod eklemek istediğimiz zaman yeni method yazıp onu mustun içine eklememiz gerekli

        }


    }
}
