using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.Builder
{
	public class CustomerBuilder
	{
		private Customer customer = new Customer();
		public CustomerBuilder Setfname(string fname)
		{
			customer.FName = fname;
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
			customer.Region = region;
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

}
