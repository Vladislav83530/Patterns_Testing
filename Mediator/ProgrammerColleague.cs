﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) :base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to programmer: " + message);
        }
    }
}
