using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.Builder
{
	public class OrderBuilder
	{
		private Order order = new Order();

		public OrderBuilder Setorderdate(DateOnly orderdate)
		{
			order.Orderdate = orderdate;
			return this;
		}

		public OrderBuilder Setordershipdate(DateOnly shipdate)
		{
			order.Shippeddate = shipdate;
			return this;
		}

		public OrderBuilder Setrequireddate(DateOnly requireddate)
		{
			order.Requireddate = requireddate;
			return this;
		}
		public OrderBuilder Setcustid(int id)
		{
			order.CustomerId = id;
			return this;
		}
		public OrderBuilder Setstatus(int status)
		{
			order.Status = status;
			return this;
		}
		public OrderBuilder Setcomments(string comments)
		{
			order.Comments = comments;
			return this;
		}

		public Order Build()
		{
			return order;
		}
	}
}
