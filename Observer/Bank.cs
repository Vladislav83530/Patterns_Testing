using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;

        public Bank(string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this); 
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 30)
                Console.WriteLine("Bank {0} selling Euro;  Course of Eutro: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Bank {0} buying Euro;  Couse of Euro: {1}", this.Name, sInfo.Euro);
        }
    }
}
