using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
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

                //property configurations
                builder.HasKey(p => p.Code);
                builder.Property(p => p.Code).HasColumnType("int").HasPrecision(10, 0);
                builder.Property(p => p.ProductLineID).HasColumnType("int").HasPrecision(10, 0).IsRequired();
                builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
                builder.Property(p => p.Scale).IsRequired().HasColumnType("int").HasPrecision(10,0);
                builder.Property(p => p.Vendor).HasMaxLength(100).IsRequired();
                builder.Property(p => p.ProductDescription).HasMaxLength(500).IsRequired(false);
                builder.Property(p => p.QuantityINstock).IsRequired().HasColumnType("int").HasPrecision(10, 0);
				builder.Property(p => p.BuyPrice).HasColumnType("decimal(19,0)").IsRequired();
                builder.Property(p => p.MSPR).HasMaxLength(20).IsRequired(false);

				//constraints
				builder.HasIndex(p => p.Name).IsUnique();
                builder.HasIndex(p => p.ProductLineID).IsUnique();


				//relation configurations
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

				//property configurations
                builder.HasKey(o => o.Id);
                builder.Property(o => o.CustomerId).HasColumnType("int").HasPrecision(10,0);
                builder.Property(o => o.Orderdate).IsRequired();
                builder.Property(o => o.Shippeddate).IsRequired(false);
                builder.Property(o => o.Requireddate).IsRequired();
                builder.Property(o => o.Status).IsRequired(false);
                builder.Property(o => o.Comments).HasMaxLength(500).IsRequired(false);


				//constraints
				builder.ToTable("Orders", o =>
                {
                    o.HasCheckConstraint("CK_orderdate", "Orderdate<getdate()");
                    o.HasCheckConstraint("CK_requireddate", "Requireddate>=Orderdate");
                    o.HasCheckConstraint("ck_status", "status in(0,1,2,3,4,5,6,7,8,9,10)");
				});



				//relation configurations
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

                //property configurations
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Id).HasColumnType("int").HasPrecision(10, 0);
				builder.Ignore(c => c.Name);
                builder.Property(c => c.SalesRepEmployeNumber).HasColumnType("int").HasPrecision(10, 0).IsRequired();
                builder.Property(c => c.FName).HasMaxLength(50).IsRequired(false).HasColumnName("FirstName");
                builder.Property(c => c.LName).HasMaxLength(50).IsRequired(false).HasColumnName("LastName");
                builder.Property(c => c.Address1).HasMaxLength(100).IsRequired(false).HasColumnName("address");
                builder.Property(c => c.Address2).HasMaxLength(100).IsRequired(false).HasColumnName("second address");
                builder.Property(c => c.City).HasMaxLength(50).IsRequired(false);
                builder.Property(c => c.Region).HasMaxLength(50).IsRequired(false);
                builder.Property(c => c.Country).HasMaxLength(50).IsRequired(false);
                builder.Property(c => c.Phone).HasMaxLength(20).IsRequired(false);
                builder.Property(c => c.State).HasMaxLength(50).IsRequired(false);
                builder.Property(c => c.CreditLimit).HasColumnType("decimal(19,0)").IsRequired(false);

				//constraints
                builder.HasIndex(c => new { c.Address1, c.Address2, c.City, c.Region, c.Country,c.FName,c.LName }).IsUnique();//not allow cust same name and same address 

				//property configurations

                //no need to make it again
				//builder.HasMany(c => c.Orders)
    //                .WithOne(o => o.Customer)
    //                .HasForeignKey(c => c.CustomerId)
    //                .OnDelete(DeleteBehavior.Cascade);

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
				//property configurations
				builder.HasKey(e => e.Id);
                builder.Property(e => e.Id).HasColumnType("int").HasPrecision(10, 0).IsRequired();
				builder.Property(e => e.Managerid).HasColumnType("int").HasPrecision(10, 0).IsRequired(false);
				builder.Property(e => e.OfficeCode).IsRequired();
				builder.Property(e => e.FName).HasMaxLength(255).IsRequired(false).HasColumnName("FirstName");
				builder.Property(e=>e.LName).HasMaxLength(255).IsRequired(false) .HasColumnName("LastName");
                builder.Property(e => e.Email).HasMaxLength(255).IsRequired(false);
				builder.Property(e => e.Extension).HasMaxLength(255).IsRequired(false);
                builder.Property(e => e.JobTitle).HasMaxLength(100).IsRequired();

				//constraints
                builder.HasIndex(e=>e.Email).IsUnique();

				//relationship configurations
				builder.HasOne(e => e.Manager)
                    .WithMany(m => m.Employees)
                    .HasForeignKey(e => e.Managerid)
                    .OnDelete(DeleteBehavior.SetNull);
                //no need to make it again
				//builder.HasMany(e => e.Customers)
    //                .WithOne(c => c.Employee)
    //                .HasForeignKey(c => c.SalesRepEmployeNumber)
    //                .OnDelete(DeleteBehavior.SetNull);

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
				//property configurations
				builder.HasKey(o=>o.ID);
                builder.Property(o => o.ID).HasColumnType("int").HasPrecision(10, 0);
                builder.Property(o => o.City).HasMaxLength(255).IsRequired(false);
                builder.Property(o => o.Phone).HasMaxLength(255).IsRequired(false);
                builder.Property(o => o.ADDress1).HasMaxLength(255).IsRequired(false).HasColumnName("address");
                builder.Property(o => o.ADDress2).HasMaxLength(255).IsRequired(false).HasColumnName("second address");
                builder.Property(o => o.State).HasMaxLength(255).IsRequired(false);
                builder.Property(o => o.Country).HasMaxLength(255).IsRequired(false);
                builder.Property(o => o.PostalCode).IsRequired(false);
                builder.Property(o => o.Territory).HasMaxLength(255).IsRequired(false);


				//constraints
				builder.HasIndex(o => new { o.State,o.Country,o.City,o.ADDress1, o.ADDress2 }).IsUnique();

				//relationship configurations no need to make it again
				//builder.HasMany(o=>o.Employees)
    //                .WithOne(e=>e.Office)
    //                .HasForeignKey(e=>e.OfficeCode)
    //                .OnDelete(DeleteBehavior.Cascade);
            }
        }

        public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
        {
            public void Configure(EntityTypeBuilder<Payment> builder)
            {

                //property configuration
                builder.HasKey(p => p.Checknum);
                builder.Property(p => p.Checknum).HasMaxLength(255);
				builder.Property(p => p.PaymebntDate).IsRequired(false);
				builder.Property(p => p.CustomerId).HasColumnType("int").HasPrecision(10,0).IsRequired();
                builder.Property(p => p.Amount).HasColumnType("decimal(19,0)").IsRequired(false);

                //make it before no need to make it again
				//builder.HasOne(p => p.Customer)
				//    .WithMany(c => c.Payments)
				//    .HasForeignKey(c => c.Equals)
				//    .OnDelete(DeleteBehavior.SetNull);
			}
		}

		public class ProductLineConfiguration : IEntityTypeConfiguration<ProductLine>
		{
			public void Configure(EntityTypeBuilder<ProductLine> builder)
			{


                //property configuration
                builder.HasKey(p => p.ID);
                builder.Property(p => p.ID).HasColumnType("int").HasPrecision(10, 0);
                builder.Property(p => p.DescLNText).HasMaxLength(255).IsRequired(false);
				builder.Property(p => p.DescLNHtml).HasMaxLength(255).IsRequired(false);
				builder.Property(p => p.Image).HasMaxLength(100).IsRequired(false);

                //make it  before  no need to make it again
				//builder.HasMany(pl => pl.Products)
				//    .WithOne(p => p.ProductLine)
				//    .HasForeignKey(p => p.ProductLineID)
				//    .OnDelete(DeleteBehavior.Cascade);
			}
		}

        public class OrderProductsConfiguration:IEntityTypeConfiguration<OrderProduct>
        {
            public void Configure(EntityTypeBuilder<OrderProduct> builder)
            {
                //property configuration
                builder.HasKey(o => o.ID);
                builder.Property(o => o.ID).HasColumnType("int").HasPrecision(10, 0);
				builder.Property(o => o.OrderId).HasColumnType("int").HasPrecision(10, 0).IsRequired();
				builder.Property(o => o.ProductCode).HasColumnType("int").HasPrecision(10, 0).IsRequired();
				builder.Property(o => o.Quantity).HasColumnType("int").HasPrecision(10, 0).IsRequired(false);
				builder.Property(o => o.ProductCode).HasColumnType("decimal(19,0)").IsRequired(false);

                // make it no need to make it again
				//builder.HasOne(or => or.Product)
    //                .WithMany(p => p.OrderProducts)
    //                .HasForeignKey(or => or.ProductId)
    //                .OnDelete(DeleteBehavior.Cascade);
				//builder.HasOne(or => or.Order)
				//	.WithMany(p => p.OrderProducts)
				//	.HasForeignKey(or => or.OrderId)
				//	.OnDelete(DeleteBehavior.Cascade);
			}
        }
	}
}
