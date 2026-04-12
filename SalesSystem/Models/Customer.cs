using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalesSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
		public Guid? SalesRepEmployeNumber { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string Name { get; set
			{
				if (FName == null & LName == null)
					value = null;
				else if (FName == null)
					value = LName;
				else if (LName == null)
					value = Name;
				else
					value = FName + LName;
			}

			}
			
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public decimal CreditLimit { get; set; }

		//navigation properties
		public virtual ICollection<Order>?Orders { get; set; }=new HashSet<Order>();
        public virtual ICollection<Payment>?Payments { get; set; }=new HashSet<Payment>();
        public virtual ICollection<Employeecustomer>? Employeecustomers { get; set; }=new HashSet<Employeecustomer>();

	}
}
