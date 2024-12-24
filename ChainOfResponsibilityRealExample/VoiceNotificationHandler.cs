using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample
{
    internal class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.VoiceNotification == true)
                Console.WriteLine("Выполнено уведомление по телефону");
            else if (Successor != null)
                Successor.Handle(receiver);

        }
    }
}