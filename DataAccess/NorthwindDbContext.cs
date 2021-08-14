using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Entities.Abstract.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class NorthwindDbContext: DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DbContext)));
        }
    }
}
