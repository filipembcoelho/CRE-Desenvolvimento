using RumosCRE.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace RumosCRE.Domain.Core.Events
{
    public interface IEventStoreRepository : IDisposable
    {
        bool Store(StoredEvent @event);
        IList<StoredEvent> GetStoredEvents(string id, string entity);
    }
}
