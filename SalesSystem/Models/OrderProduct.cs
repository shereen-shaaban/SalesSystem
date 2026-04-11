using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class OrderProduct
    {
		public int ID { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int ProductCode { get; set; }
		public int Quantity { get; set; }
		public decimal PriceForeachproductorder { get; set; }


		//navigation properties
		public virtual Order? Order { get; set; }
		public virtual Product? Product { get; set; }


	}
}
