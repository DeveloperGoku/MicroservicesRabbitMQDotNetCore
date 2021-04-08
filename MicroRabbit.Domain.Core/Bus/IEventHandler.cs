using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    // event handler takes in any type of event and implements event handler
   public interface IEventHandler <in TEvent> : IEventHandler where TEvent: Event
    {
        Task Handle(TEvent @event);
    }
    public interface IEventHandler
    {

    }

}
