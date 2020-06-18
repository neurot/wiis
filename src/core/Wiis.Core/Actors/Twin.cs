using System;
using Akka.Actor;

namespace Wiis.Core.Actors
{
    public class Twin : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}