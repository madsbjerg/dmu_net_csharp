using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccessLayer
{
    public sealed class DataContext : DbContext
    {
        private static readonly DataContext instance = new DataContext();

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarWheel> CarWheels { get; set; }
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
            modelBuilder.Entity<Car>().HasData(new Car[]
            {
                new Car(
                    id: -1, 
                    model: "Golf II GTI", 
                    type: "Hatchback", 
                    description: "In great condition! Still has 3 wheels.",
                    weight: "1500"
                ),
                new Car(
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