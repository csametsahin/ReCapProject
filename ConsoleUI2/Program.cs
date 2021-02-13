using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAllTest();
            //BrandAddTest();
            //ColorAddTest();
            //   GetCarDetailTest();
           // UserGetAllTest();

        }

        private static void UserGetAllTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void GetCarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.BrandName + " " + item.ColorName + " " + item.Description);
            }
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Tesla" });
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 2, BrandId = 2, DailyPrice = 550, ModelYear = 2010, Description = "Bmw 320" });
            carManager.Add(new Car { ColorId = 1, BrandId = 1, DailyPrice = 450, ModelYear = 2015, Description = "Nice Car" });
            carManager.Add(new Car { ColorId = 3, BrandId = 3, DailyPrice = 330, ModelYear = 2017, Description = "Great Car" });
            carManager.Add(new Car { ColorId = 4, BrandId = 1, DailyPrice = 210, ModelYear = 2018, Description = "Worst Car" });
            carManager.Add(new Car { ColorId = 1, BrandId = 3, DailyPrice = 150, ModelYear = 2019, Description = "Expensive Car" });

            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
        }


    }
}
