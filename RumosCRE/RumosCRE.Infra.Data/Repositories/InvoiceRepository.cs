using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class InvoiceRepository : Repository<Invoice, int>, IInvoiceRepository
    {
        public InvoiceRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
