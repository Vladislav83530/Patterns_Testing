using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Stock :IObservable
    {
        StockInfo sInfo;

        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach(IObserver ob in observers)
            {
                ob.Update(sInfo);
            }
        }

        public void RegisterObserver(IObserver ob)
        {
            observers.Add(ob);
        }

        public void RemoveObserver(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(30, 50);
            sInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}
