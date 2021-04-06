using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile proje klaslarını bağlamak
    public class CarRentalContext: DbContext //kurduğumuz entityframework ile DbContext geliyor.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projem hangi veritabanıyla ilişkili
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarRental;Trusted_Connection=true"); //hangi veritabanına bağlanacağımızı söylüyoruz
        }
        //hangi veritabanına bağlanacağımızı söylüyoruz

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

    }
}
