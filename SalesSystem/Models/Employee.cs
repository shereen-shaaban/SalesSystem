using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
		public int OfficeCode { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string Email { get; set; }
        public string Extension { get; set; }
		public string JobTitle { get; set; }
		public int ReportsTo { get; set; }
        public int? Managerid { get; set; }
		public virtual ICollection<Customer>? Customer { get; set; }
		public virtual Employee? Manager { get; set; }
		public	virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

		public virtual Office Office { get; set; }



    }
}
