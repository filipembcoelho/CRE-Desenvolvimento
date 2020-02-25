using System;
using System.Collections.Generic;
using System.Text;

namespace RumosCRE.Domain.Models
{
    public class Employee : Person
    {

        public int Id { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}
