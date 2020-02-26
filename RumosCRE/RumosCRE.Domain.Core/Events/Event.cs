using MediatR;
using System;

namespace RumosCRE.Domain.Core.Events
{
    public class Event : Message, INotification
    {
        public DateTime TimeStamp { get; set; }

        public Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
