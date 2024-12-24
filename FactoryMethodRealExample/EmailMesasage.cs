using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    internal class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("Email отправлен");        
        }
    }
}
