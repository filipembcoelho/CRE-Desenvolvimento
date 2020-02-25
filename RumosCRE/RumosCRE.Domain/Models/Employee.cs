using System.Collections.Generic;

namespace RumosCRE.Domain.Models
{
    public class Employee : Person
    {

        public int Id { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}
