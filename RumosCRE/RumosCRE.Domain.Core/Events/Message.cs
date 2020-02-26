using MediatR;
using RumosCRE.Domain.Core.Models;

namespace RumosCRE.Domain.Core.Events
{
    public class Message : IRequest<Response>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
