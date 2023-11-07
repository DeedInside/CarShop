using CarShop.Model.Car;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DataContext
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=CarShop.db");
        }
    }
}
