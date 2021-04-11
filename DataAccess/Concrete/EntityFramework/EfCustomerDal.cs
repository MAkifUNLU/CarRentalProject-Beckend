using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users 
                             on customer.UserId equals user.Id
                             select new CustomerDetailDto()
                             {
                                 CustomerId = customer.Id,
                                 UserId = user.Id,
                                 CompanyName = customer.CompanyName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 Status = user.Status,
                                 FindexPoint = customer.FindexPoint                               
                             };
                return result.ToList();
            }
        }

        public CustomerDetailDto GetByEmail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cs in context.Customers
                             join u in context.Users
                             on cs.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = cs.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = cs.CompanyName,
                                 FindexPoint = cs.FindexPoint
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}
