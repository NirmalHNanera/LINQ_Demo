using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
    
namespace ConsoleApp1
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-DUDCGORL;Database=LINQ_DEMO;Trusted_Connection=True");
        }
    }
}
