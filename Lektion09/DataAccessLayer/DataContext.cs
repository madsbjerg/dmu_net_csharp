using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccessLayer
{
    public sealed class DataContext : DbContext
    {
        private static readonly DataContext instance = new DataContext();

        public DbSet<Bil> Biler { get; set; }
        public DataContext() 
        {
            this.Database.EnsureCreated();
        }

        public DataContext GetInstance()
        {
            return instance;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>().HasData(new Bil[]
            {
                new Bil(
                    id: -1, 
                    model: "Golf II GTI", 
                    type: "Hatchback", 
                    description: "In great condition! Still has 3 wheels.",
                    weight: "1500"
                ),
                new Bil(
                    id: -2, 
                    model: "Ford Mustang", 
                    type: "Muscle", 
                    description: "Drives fast in a straight line",
                    weight: "2000"
                )
            });
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-L9CGI95\\SQLEXPRESS;" +
            "Initial Catalog = Lektion09Opgave01; " +
            "Integrated Security = true;" +
            "TrustServerCertificate = true;");
        }

    }
}