using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
