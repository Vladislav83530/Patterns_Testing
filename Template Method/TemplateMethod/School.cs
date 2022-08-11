using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.TemplateMethod
{
     class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Go in first class");
        }

        public override void Study()
        {
            Console.WriteLine("Attending classes, doing homework");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Getting a high school diploma");
        }
    }
}
