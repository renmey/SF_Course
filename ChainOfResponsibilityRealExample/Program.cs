using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);
            NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
            NotificationHandler smsNotificationHandler = new SmsNotificationHandler();
            NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();

            emailNotificationHandler.Successor = smsNotificationHandler;
            smsNotificationHandler.Successor = voiceNotificationHandler;

            emailNotificationHandler.Handle(receiver);
            

            Console.ReadKey();
        }

    }
}
