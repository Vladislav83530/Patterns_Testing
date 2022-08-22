﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton
{
    internal class OS
    {
        private static OS instance;
        private static object syncRoot = new Object();

        public string Name { get; private set; }

        protected OS(string name)
        {
            Name = name;    
        }

        public static OS GetInstance(string name)
        {
            if(instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new OS(name);
                    }
                }
            }
            return instance;
        }
    }
}
