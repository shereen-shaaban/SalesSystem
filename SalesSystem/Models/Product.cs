using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Product
    {
        public int Code { get; set; }
        public int ProductLineID { get; set; }
        public string Name { get; set; }
        public int   Scale { get; set; }
        public string Vendor { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityINstock { get; set; }
        public decimal BuyPrice { get; set; }
        public string MSPR { get; set; }


		//navigation properties
		public virtual ProductLine? ProductLine { get; set; }
        public virtual ICollection<OrderProduct>?OrderProducts { get; set; }=new HashSet<OrderProduct>();



    }
}
