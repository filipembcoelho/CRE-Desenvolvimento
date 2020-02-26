using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.Data.Repositories
{
    public class InvoiceLineRepository : Repository<InvoiceLine, int>, IInvoiceLineRepository
    {
        public InvoiceLineRepository(RumosCreDbContext context) : base(context)
        {
        }
    }
}
