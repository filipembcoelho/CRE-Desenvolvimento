using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
