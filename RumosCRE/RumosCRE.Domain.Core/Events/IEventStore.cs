namespace RumosCRE.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T @event, string id) where T : Event;
    }
}
