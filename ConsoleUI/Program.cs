using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());

            //-----------------------------CarDetails CRUD Testleri----------------------------------

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.ColorName+" "+car.BrandName+" "+car.Description+" "+car.DailyPrice+"TL");
            //}

            //------------------------------CarManager CRUD Testleri--------------------------------

            //CarGetAllTest();
            //CarGetByIdTest();
            //GetCarsByBrandIdTest();
            //GetCarsByColorIdTest();
            //carManager.Add(new Car {CarName = "Kepçe",BrandId=2,ColorId=1,Description="Kazma yapar",DailyPrice=50});
            //carManager.Update(new Car { Id = 7, CarName = "Kamyon",BrandId = 3, ColorId = 3, DailyPrice = 500 });
            //carManager.Delete(new Car { Id = 7 });

            //------------------------------BrandManager CRUD Testleri--------------------------------

            //BrandGetAllTest();
            //BrandGetByIdTest();
            //brandManager.Add(new Brand {BrandName = "Ford"});
            //brandManager.Update(new Brand { BrandId = 5, BrandName = "Toyota" });
            //brandManager.Delete(new Brand { BrandId = 5 });

            //-----------------------------ColorManager CRUD Testleri--------------------------------

            //ColorGetAllTest();
            //ColorGetByIdTest();
            //colorManager.Add(new Color { ColorName="Yeşil"});
            //colorManager.Update(new Color { ColorId=5,ColorName="Sarı"});
            //colorManager.Delete(new Color { ColorId = 5});
        }

        private static void CarGetByIdTest()
        {
            CarManager carGetById = new CarManager(new EfCarDal());
            Console.WriteLine(carGetById.GetById(2).CarName);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void GetCarsByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void GetCarsByColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandGetById = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandGetById.GetById(2).BrandName);
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.BrandName);
            }
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorGetById = new ColorManager(new EfColorDal());
            Console.WriteLine(colorGetById.GetById(2).ColorName);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            {
                foreach (var r in colorManager.GetAll())
                {
                    Console.WriteLine(r.ColorName);
                }
            }
        }





    }
}
