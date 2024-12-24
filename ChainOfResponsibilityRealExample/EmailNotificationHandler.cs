﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample
{
    internal class EmailNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.EmailNotification == true)
            {
                Console.WriteLine("Выполнено уведомление по e-mail");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }

        }
    }
}
