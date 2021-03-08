using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile proje klaslarını bağlamak
    public class MyDatabaseContext: DbContext //kurduğumuz entityframework ile DbContext geliyor.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projem hangi veritabanıyla ilişkili
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=true"); //hangi veritabanına bağlanacağımızı söylüyoruz
        }
        //hangi veritabanına bağlanacağımızı söylüyoruz

        public DbSet<Car> Carss { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
