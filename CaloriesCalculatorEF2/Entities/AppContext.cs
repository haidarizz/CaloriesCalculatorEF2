using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2.Entities
{
    class AppContext : DbContext
    {
        public DbSet<General> Generals { get; set; }
        public DbSet<Body> Bodies { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppCaloriesCalculatorDb;");
        }
    }
}
