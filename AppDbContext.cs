using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _26_04_2022.Models.DataAccess
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8LGITHD;Database=CompanyDb;Integrated Security=true");
        }
        public DbSet<Employee> Employees { get; set; } 
    }
}
