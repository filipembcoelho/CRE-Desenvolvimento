using RumosCRE.Application.Interfaces;
using RumosCRE.Domain.Core.Models;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace RumosCRE.Domain.Core.Events
{
    public class EventStore : IEventStore
    {
        private readonly IEventStoreRepository _repo;
        private readonly IUserAccessor _userAccessor;

        public EventStore(IEventStoreRepository repo, IUserAccessor userAccessor)
        {
            _repo = repo;
            _userAccessor = userAccessor;
        }

        public void Save<T>(T @event, string id) where T : Event
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            var serializedData = JsonSerializer.Serialize(@event, options);

            var eventToStore = new StoredEvent(@event, id, serializedData, _userAccessor.GetCurrentUserName());

            _repo.Store(eventToStore);
        }
    }
}
