using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");

            stock.Notify += bank.Update;
            stock.Notify += broker.Update;
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
