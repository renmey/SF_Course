    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverRealExample.Observers;

namespace ObserverRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();

            var bank = new Bank(stock);
            var broker = new Broker(stock);

            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            Console.ReadKey();  

        }
    }
}
