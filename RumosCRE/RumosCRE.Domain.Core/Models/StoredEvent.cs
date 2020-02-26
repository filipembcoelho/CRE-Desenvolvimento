using RumosCRE.Domain.Core.Events;

namespace RumosCRE.Domain.Core.Models
{
    public class StoredEvent : Event
    {
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string Data { get; set; }
        public string User { get; set; }

        public StoredEvent()
        {
        }

        public StoredEvent(Event @event, string id, string data, string user) : this()
        {
            EntityId = id;
            MessageType = @event.MessageType;
            Data = data;
            User = user;
        }
    }
}
