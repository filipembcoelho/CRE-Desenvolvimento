using System.Collections.Generic;

namespace RumosCRE.Domain.Models
{
    public class Customer : Person
    {
        public int Id { get; set; }

        public IEnumerable<Invoice> Invoices { get; set; }
    }
}
