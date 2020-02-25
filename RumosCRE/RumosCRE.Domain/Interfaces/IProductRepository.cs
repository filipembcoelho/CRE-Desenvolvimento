using System;
using System.Collections.Generic;
using System.Text;
using RumosCRE.Domain.Models;

namespace RumosCRE.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
