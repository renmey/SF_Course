using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRealExample
{
    abstract class MessageSender
    {
        public string From {  get; set; }
        public MessageSender(string @from)
        {
            From = @from;
        }

        abstract public Message Send(string text);

    }
}
