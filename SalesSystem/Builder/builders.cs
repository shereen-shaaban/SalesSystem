using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.NewFolder
{
    public  class ProductBuilder
    {

        private Product product =new Product();
         
        public ProductBuilder Setproductline(int Line)
        {
            product.ProductLineID = Line;
            return this;
        }

        public ProductBuilder Setname(string name)
        {
            product.Name = name;
            return this;
        }
        public ProductBuilder  Setscale(int Scale)
        {
            product.Scale = Scale;
            return this;
        }
		public ProductBuilder Setvendor(string vendor)
		{
			product.Vendor = vendor;
			return this;
		}
        public ProductBuilder Setproductdescription(string productdescription)
        {
            product.ProductDescription = productdescription;
            return this;
        }
        public ProductBuilder Setquantutyinstock(int quantity)
        {
            product.QuantityINstock=quantity;
            return this;
        }
        public ProductBuilder Setprice(decimal price)
        {
            product.BuyPrice=price;
            return this;
        }
        public ProductBuilder setmspr(string mspr)
        {
            product.MSPR=mspr;
            return this;
        }

        public Product Build()
        {
            return product;
        }


	}
    public class OrderBuilder
    {
        private Order order = new Order();

        public OrderBuilder Setorderdate(DateOnly orderdate)
        {
            order.Orderdate=orderdate;
            return this;
        }

        public OrderBuilder Setordershipdate(DateOnly shipdate)
        {
            order.Shippeddate=shipdate;
            return this;
        }

        public OrderBuilder Setrequireddate(DateOnly requireddate)
        {
            order.Requireddate=requireddate;
            return this;
        }
        public OrderBuilder Setcustid(int id)
        {
            order.CustomerId=id;
            return this;
        }
        public OrderBuilder Setstatus(int status)
        {
            order.Status=status;
            return this;
        }
        public OrderBuilder Setcomments(string comments)
        {
            order.Comments=comments;
            return this;
		}

        public Order Build()
        {
            return order;
        }
    }
    public class EmployeeBuilder
    {
        private Employee employee = new Employee();
        public EmployeeBuilder Setofficecode(int code)
        {
            employee.OfficeCode=code;
            return this;
        }

        public  EmployeeBuilder Setfname(string fname)
        {
            employee.FName=fname;
            return this;
        }

        public EmployeeBuilder Setlname(string lname)
        {
            employee.LName = lname;
            return this;
        }

        public EmployeeBuilder Setemail(string email)
        {
            employee.Email = email;
            return this;
        }

        public EmployeeBuilder Setextension(string extension)
        {
            employee.Extension = extension;
            return this;
        }
        public EmployeeBuilder Setjobtitle(string title)
        {
            employee.JobTitle=title;
            return this;
        }
        public EmployeeBuilder Setmanagerid(Guid managerid)
        {
            employee.Managerid = managerid;
            return this;
        }

        public Employee Build()
        {
            return employee;
        }
    }
    public class CustomerBuilder
    {
        private Customer customer = new Customer();
        public CustomerBuilder Setfname(string fname)
        {
            customer.FName=fname;
            return this;
        }
		public CustomerBuilder Setlname(string lname)
		{
			customer.LName = lname;
			return this;
		}
		public CustomerBuilder Setaddress1(string address1)
		{
			customer.Address1 = address1;
			return this;
		}
		public CustomerBuilder Setaddress2(string address2)
		{
			customer.Address2 = address2;
			return this;
		}
        public CustomerBuilder Setcity(string city)
        {
            customer.City = city;
            return this;
        }
        public CustomerBuilder Setstate(string state)
        {
            customer.State = state;
            return this;
        }
        public CustomerBuilder Setregion(string region)
        {
            customer.Region= region;
            return this;
        }
        public CustomerBuilder Setcountry(string country)
        {
            customer.Country = country;
            return this;
        }
        public CustomerBuilder Setphone(string phone)
        {
            customer.Phone = phone;
            return this;
        }
        public CustomerBuilder Setpostalcode(int postal)
        {
            customer.PostalCode = postal;
            return this;
        }
        public Customer Build()
        {
            return customer;
        }
	}
    public class ProductLineBuilder
    {
        private ProductLine productline=new ProductLine();

        public ProductLineBuilder SetText(string Name)
        {
            productline.DescLNText = Name;
            return this;
        }

        public ProductLineBuilder Sethtml(string desc)
        {
            productline.DescLNHtml = desc;
            return this;
        }
		public ProductLineBuilder Setimage(string image)
		{
			productline.Image = image;
			return this;
		}

        public ProductLine Build()
        {
            return productline;
        }

	}


}
