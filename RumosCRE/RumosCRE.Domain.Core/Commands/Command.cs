using RumosCRE.Domain.Core.Events;
using System;

namespace RumosCRE.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

    }
}
