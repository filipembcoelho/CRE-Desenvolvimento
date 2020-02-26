using MediatR;
using RumosCRE.Domain.Core.Bus;
using RumosCRE.Domain.Core.Commands;
using RumosCRE.Domain.Core.Events;
using RumosCRE.Domain.Core.Models;
using System.Threading.Tasks;

namespace RumosCRE.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;

        public InMemoryBus(IMediator mediator, IEventStore eventStore)
        {
            _mediator = mediator;
            _eventStore = eventStore;
        }

        public Task<Response> SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public void RaiseEvent<T>(T @event, string id) where T : Event
        {
            _eventStore.Save(@event, id);
        }
    }
}
