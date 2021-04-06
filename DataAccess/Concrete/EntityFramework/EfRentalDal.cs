using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cus in context.Customers
                             on re.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CarId = ca.Id,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 CompanyName = cus.CompanyName,
                                 CarModelYear = ca.ModelYear,
                                 CarDailyPrice = ca.DailyPrice,
                                 CarDescription = ca.Description,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                                 //CustomerFullName = us.FirstName + " " + us.LastName,
                                 //UserName = us.FirstName + " " + us.LastName,
                                 //CompanyName = cus.CompanyName,                              
                                 //RentDate = re.RentDate,
                                 //RentStartDate = re.RentStartDate,
                                 //RentEndDate = re.RentEndDate,
                                 //ReturnDate = re.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
