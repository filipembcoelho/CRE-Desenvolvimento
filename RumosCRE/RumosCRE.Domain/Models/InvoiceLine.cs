using System;
using System.Collections.Generic;
using System.Text;

namespace RumosCRE.Domain.Models
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal ProductValue { get; set; }
        public decimal Total { get; set; }
    }
}
