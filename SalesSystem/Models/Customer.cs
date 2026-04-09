using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
		public int SalesRepEmployeNumber { get; set; }

		public string Name { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public decimal CreditLimit { get; set; }

    }
}
