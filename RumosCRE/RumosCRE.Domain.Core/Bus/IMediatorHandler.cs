using RumosCRE.Domain.Core.Commands;
using RumosCRE.Domain.Core.Events;
using RumosCRE.Domain.Core.Models;
using System.Threading.Tasks;

namespace RumosCRE.Domain.Core.Bus
{
    public interface IMediatorHandler
    {

        Task<Response> SendCommand<T>(T command) where T : Command;

        void RaiseEvent<T>(T @event, string id) where T : Event;
    }
}
