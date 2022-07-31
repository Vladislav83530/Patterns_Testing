using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product.ConcreateProduct
{
    class PanelHouse:House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house done");
        }
    }
}
