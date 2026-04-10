using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesSystem.Models;

namespace SalesSystem.Configuration
{
    public class Configurations
    {
        public class ProductConfiguration:IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product>builder)
            {
                builder.HasMany(p => p.OrderProducts)
                    .WithOne(o => o.Product)
                    .HasForeignKey(o => o.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(p => p.ProductLine)
                    .WithMany(pr => pr.Products)
                    .HasForeignKey(p => p.ProductLineID);
            }
        }

        public class OrderConfiguration:IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order>builder)
            {
                builder.HasMany(o => o.OrderProducts)
                    .WithOne(or => or.Order)
                    .HasForeignKey(o => o.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(o => o.Customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }

        public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
        {
            public void Configure(EntityTypeBuilder<Customer>builder)
            {
                builder.HasMany(c => c.Orders)
                    .WithOne(o => o.Customer)
                    .HasForeignKey(c => c.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);

                builder.HasMany(c => c.Payments)
                    .WithOne(p => p.Customer)
                    .HasForeignKey(p => p.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull);

                builder.HasOne(c => c.Employee)
                    .WithMany(e => e.Customers)
                    .HasForeignKey(c => c.SalesRepEmployeNumber)
                    .OnDelete(DeleteBehavior.SetNull); 
            }
        }

        public class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                builder.HasMany(e => e.Customers)
                    .WithOne(c => c.Employee)
                    .HasForeignKey(c => c.SalesRepEmployeNumber)
                    .OnDelete(DeleteBehavior.SetNull);

                builder.HasOne(e => e.Office)
                    .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeCode)
                .OnDelete(DeleteBehavior.Cascade);
            }
        }

        public class OfficeConfiguration:IEntityTypeConfiguration<Office>
        {
            public void Configure(EntityTypeBuilder<Office> builder)
            {
                builder.HasMany(o=>o.Employees)
                    .WithOne(e=>e.Office)
                    .HasForeignKey(e=>e.OfficeCode)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }

        public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
        {
            public void Configure(EntityTypeBuilder<Payment> builder)
            {
                builder.HasOne(p => p.Customer)
                    .WithMany(c => c.Payments)
                    .HasForeignKey(c => c.Equals)
                    .OnDelete(DeleteBehavior.SetNull);
            }
        }

		public class ProductLineConfiguration : IEntityTypeConfiguration<ProductLine>
		{
			public void Configure(EntityTypeBuilder<ProductLine> builder)
			{
                builder.HasMany(pl => pl.Products)
                    .WithOne(p => p.ProductLine)
                    .HasForeignKey(p => p.ProductLineID)
                    .OnDelete(DeleteBehavior.Cascade);
			}
		}

        public class OrderProductsConfiguration:IEntityTypeConfiguration<OrderProduct>
        {
            public void Configure(EntityTypeBuilder<OrderProduct> builder)
            {
                builder.HasOne(or => or.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(or => or.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
				builder.HasOne(or => or.Order)
					.WithMany(p => p.OrderProducts)
					.HasForeignKey(or => or.OrderId)
					.OnDelete(DeleteBehavior.Cascade);
			}
        }
	}
}
