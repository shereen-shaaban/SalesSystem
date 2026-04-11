using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SalesSystem.Context
{
    public class AppDBContext:DbContext     
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               string connection = "Server=localhost;DataBase=SalesSystem;Trusted_Connection=true;TrustServerCertificate=true";
                optionsBuilder.UseSqlServer(connection);
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }



		//local containers
		public DbSet<Models.Office> Offices { get; set; }
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Payment> Payments { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.OrderProduct> OrderProducts { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.ProductLine> ProductLines { get; set; }


	}
}
