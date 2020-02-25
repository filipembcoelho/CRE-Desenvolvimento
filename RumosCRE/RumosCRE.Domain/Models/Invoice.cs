using System;
using System.Collections.Generic;

namespace RumosCRE.Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; }
    }
}
