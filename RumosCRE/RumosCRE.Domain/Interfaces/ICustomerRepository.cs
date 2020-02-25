using System;
using System.Collections.Generic;
using System.Text;
using RumosCRE.Domain.Models;

namespace RumosCRE.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
    }
}
