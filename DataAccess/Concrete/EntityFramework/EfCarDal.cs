using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join ci in context.CarImages
                             on ca.Id equals ci.CarId
                             select new CarDetailDto
                             {
                                 CarId=ca.Id,
                                 CarName=ca.CarName,
                                 BrandId = br.BrandId,
                                 ColorId = co.ColorId,
                                 ColorName = co.ColorName,
                                 BrandName = br.BrandName,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 DailyPrice = ca.DailyPrice,
                                 ImageId = ci.Id,
                                 ImagePath = ci.ImagePath,
                                 Date = ci.Date,
                                 Status = !context.Rentals.Any(r => r.CarId == ca.Id && (r.ReturnDate == null || r.ReturnDate > DateTime.Now)),
                                 FindexPoint = ca.FindexPoint
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
