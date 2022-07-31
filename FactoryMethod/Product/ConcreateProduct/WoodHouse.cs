using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product.ConcreateProduct
{
    class WoodHouse :House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood House done");
        }
    }
}
