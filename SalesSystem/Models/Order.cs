using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateOnly Orderdate { get; set; }
		public DateOnly Shippeddate { get; set; }
		public DateOnly Requireddate { get; set; }

		public int CustomerId { get; set; }
		public int Status { get; set; }

		public string Comments { get; set; }
    }
}
