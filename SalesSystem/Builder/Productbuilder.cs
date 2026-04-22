using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.Builder
{
	public class ProductBuilder
	{

		private Product product;

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
		public ProductBuilder Setscale(int Scale)
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
			product.QuantityINstock = quantity;
			return this;
		}
		public ProductBuilder Setprice(decimal price)
		{
			product.BuyPrice = price;
			return this;
		}
		public ProductBuilder Setmspr(string mspr)
		{
			product.MSPR = mspr;
			return this;
		}
		public Product Build()
		{
			return product;
		}
	}
}
