using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Office
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string ADDress1 { get; set; }
		public string ADDress2 { get; set; }
		public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Territory { get; set; }

		//navigation properties
		public virtual ICollection<Employee>? Employees { get; set; }=new HashSet<Employee>();

    }
}
