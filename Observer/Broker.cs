using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        public Broker(string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 40)
            {
                Console.WriteLine("Broker {0} selling USDs;  Course of USD: {1}", this.Name, sInfo.USD);
            }
            else
            {
                Console.WriteLine("Broker {0} buying USDs;  Course of USD: {1}", this.Name, sInfo.USD);
            }
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
