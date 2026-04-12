using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.Identity.Client;

namespace SalesSystem.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
		public int OfficeCode { get; set; }

		public string? FName { get; set; }
		public string? LName { get; set; }
		public string? Email { get; set; }
        public string? Extension { get; set; }
		public string? JobTitle { get; set; }
        public Guid? Managerid { get; set; }




		// Navigation properties
		public virtual Employee? Manager { get; set; }
		public virtual Office? Office { get; set; }
		public	virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
		public virtual ICollection<Employeecustomer>? Employeecustomers { get; set; }=new HashSet<Employeecustomer>();





	}
}
