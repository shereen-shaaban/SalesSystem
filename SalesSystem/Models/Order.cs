using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateOnly Orderdate { get; set; }
		public DateOnly Shippeddate { get; set; }
		public DateOnly Requireddate { get; set; }

		public int CustomerId { get; set; }
		public int Status { get; set; }

		public string Comments { get; set; }


		//navigation properties
		public virtual ICollection<OrderProduct>? OrderProducts { get; set; } = new HashSet<OrderProduct>();

		public virtual Customer? Customer { get; set; }
    }
}
