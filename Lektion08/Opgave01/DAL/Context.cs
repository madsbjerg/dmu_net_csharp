using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01.DAL
{
    internal class Context : DbContext
    {
        public DbSet<BilModel> biler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BilModel>().HasData(new BilModel[]
            {
                new BilModel(-1, "Ford", "Explorer", 150),
                new BilModel(-2, "Fiat", "Punto", 60),
                new BilModel(-3, "Ford", "Mustang", 150)
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-L9CGI95\\SQLEXPRESS;" +
                "Initial Catalog = lektion08opgave01; " +
                "Integrated Security = true;"+
                "TrustServerCertificate = true;"
                //options => options.EnableRetryOnFailure()
            );
        }
    }
}
