using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Models
{
    public class Payment
    {
        public string Checknum { get; set; }
        public int CustomerId { get; set; }
        public DateOnly PaymebntDate { get; set; }
        public decimal Amount { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
