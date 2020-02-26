using RumosCRE.Domain.Core.Events;
using RumosCRE.Domain.Core.Models;
using RumosCRE.Infra.EventSourceData.Context;
using System.Collections.Generic;
using System.Linq;

namespace RumosCRE.Infra.EventSourceData.Repositories
{
    public sealed class EventStoreRepository : IEventStoreRepository
    {
        private readonly RumosCreEventStoreDbContext _context;

        public EventStoreRepository(RumosCreEventStoreDbContext context)
        {
            _context = context;
        }

        public bool Store(StoredEvent @event)
        {
            _context.EventStores.Add(@event);
            return _context.SaveChanges() > 0;
        }

        public IList<StoredEvent> GetStoredEvents(string id, string entity)
        {
            return _context.EventStores.Where(x => x.EntityId == id && x.MessageType.Contains(entity)).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
