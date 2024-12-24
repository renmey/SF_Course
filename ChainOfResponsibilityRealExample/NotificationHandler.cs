using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample
{
    abstract class NotificationHandler
    {
        public NotificationHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);

    }
}
