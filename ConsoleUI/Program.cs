using Business.Concrete;
using Business.Constants;
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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //-----------------------------CarDetails CRUD Testleri----------------------------------

            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(car.ColorName + " " + car.BrandName + " " + car.Description + " " + car.DailyPrice + "TL");
            //}

            //-----------------------------RentalDetails CRUD Testleri----------------------------------

            //foreach (var r in rentalManager.GetRentalDetails().Data)
            //{
            //    Console.WriteLine(r.CarName+" "+r.UserName+" Kiralama Tarihi:"+r.RentDate+" Teslim Tarihi:"+r.ReturnDate);
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
            //brandManager.Update(new Brand { BrandId = 6, BrandName = "Toyota" });
            //brandManager.Delete(new Brand { BrandId = 6 });

            //-----------------------------ColorManager CRUD Testleri--------------------------------

            //ColorGetAllTest();
            //ColorGetByIdTest();
            //colorManager.Add(new Color { ColorName="Yeşil"});
            //colorManager.Update(new Color { ColorId=5,ColorName="Sarı"});
            //colorManager.Delete(new Color { ColorId = 5});

            //-----------------------------CustomerManager CRUD Testleri--------------------------------

            //CustomerGetAllTest();
            //CustomerGetByIdTest();
            //customerManager.Add(new Customer { UserId=3, CompanyName="Bireysel"});
            //customerManager.Update(new Customer { UserId=5,CompanyName="....Holding"});
            //customerManager.Delete(new Customer { UserId = 5});

            //-----------------------------RentalManager CRUD Testleri--------------------------------

            //RentalGetAllTest();    Rental Detail DTO da var 
            //RentalGetByIdTest();   Rental Detail DTO da var 
            //rentalManager.Add(new Rental { Id=3, CarId=5, CustomerId=5, RentDate=01.01.2000,ReturnDate=02.02.2020});
            //rentalManager.Update(new Rental { Id=4, CarId=6, CustomerId=8, RentDate=01.01.2000,ReturnDate=02.02.2020});
            //rentalManager.Delete(new Renatal { Id=4});

            //-----------------------------UserManager CRUD Testleri--------------------------------

            //UserGetAllTest();
            //UserGetByIdTest();
            //userManager.Add(new User { UserId=3, FirstName="Ali", LastName="Demir", EMail="...@mail.com", Password="1234"});
            //userManager.Update(new User { UserId=4, FirstName="Veli", LastName="Bakır", EMail="..?.@mail.com", Password="abcd"});
            //userManager.Delete(new User { UserId = 4});
        }

        private static void UserGetAllTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var c in userManager.GetAll().Data)
            {
                Console.WriteLine(c.FirstName + c.LastName);
            }
            Console.WriteLine(Messages.UsersListed);
        }

        private static void UserGetByIdTest()
        {
            UserManager userGetById = new UserManager(new EfUserDal());
            Console.WriteLine(userGetById.GetById(3).Data.FirstName);//" "+userGetById.GetById(3).Data.LastName
        }

        private static void CustomerGetByIdTest()
        {
            CustomerManager customerGetById = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerGetById.GetById(2).Data.CompanyName);
        }

        private static void CustomerGetAllTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var c in customerManager.GetAll().Data)
            {
                Console.WriteLine(c.CompanyName);
            }
            Console.WriteLine(Messages.CustomersListed);
        }

        private static void CarGetByIdTest()
        {
            CarManager carGetById = new CarManager(new EfCarDal());
            Console.WriteLine(carGetById.GetById(2).Data.CarName);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Description);
            }
            Console.WriteLine(Messages.CarsListed);
        }

        private static void GetCarsByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void GetCarsByColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandGetById = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandGetById.GetById(2).Data.BrandName);
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var b in brandManager.GetAll().Data)
            {
                Console.WriteLine(b.BrandName);
            }
            Console.WriteLine(Messages.BrandsListed);
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorGetById = new ColorManager(new EfColorDal());
            Console.WriteLine(colorGetById.GetById(2).Data.ColorName);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            {
                foreach (var r in colorManager.GetAll().Data)
                {
                    Console.WriteLine(r.ColorName);
                }
                Console.WriteLine(Messages.ColorsListed);
            }
        }





    }
}
