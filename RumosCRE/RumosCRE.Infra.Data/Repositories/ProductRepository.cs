using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
