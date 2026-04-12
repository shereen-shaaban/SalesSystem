using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesSystem.Models
{
    public class Employeecustomer
    {

      
        public int Id { get; set; }

        [ForeignKey("Employee")]
		[Required]
		public Guid Empid { get; set; }
        [ForeignKey("Customer")]
		[Required]
		public int Custid { get; set; }


		//navigation properties
		public virtual Employee? Employee { get; set; }  
        public virtual Customer? Customer { get; set; }
	}
}
