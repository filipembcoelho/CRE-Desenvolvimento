using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        protected ProductRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
