using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.Builder
{
	public class EmployeeBuilder
	{
		private Employee employee = new Employee();
		public EmployeeBuilder Setofficecode(int code)
		{
			employee.OfficeCode = code;
			return this;
		}

		public EmployeeBuilder Setfname(string fname)
		{
			employee.FName = fname;
			return this;
		}

		public EmployeeBuilder Setlname(string lname)
		{
			employee.LName = lname;
			return this;
		}

		public EmployeeBuilder Setemail(string email)
		{
			employee.Email = email;
			return this;
		}

		public EmployeeBuilder Setextension(string extension)
		{
			employee.Extension = extension;
			return this;
		}
		public EmployeeBuilder Setjobtitle(string title)
		{
			employee.JobTitle = title;
			return this;
		}
		public EmployeeBuilder Setmanagerid(Guid managerid)
		{
			employee.Managerid = managerid;
			return this;
		}

		public Employee Build()
		{
			return employee;
		}
	}
}
