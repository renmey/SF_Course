using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messageText = "Ваш заказ - 1488";

            MessageSender sender = new SmsMessageSender("+732349495");
            Message sms = sender.Send(messageText);


            sender = new EmailMessageSender("@reer.@134");
            Message email = sender.Send(messageText);

            Console.ReadKey();  


        }
    }
}
