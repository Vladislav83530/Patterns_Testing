using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ManagerMediator :Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string message, Colleague colleagua)
        {
            if(colleagua==Customer)
                Programmer.Notify(message);

            if (colleagua == Programmer)
                Tester.Notify(message);

            if (colleagua == Tester)
                Customer.Notify(message);
        }
    }
}
