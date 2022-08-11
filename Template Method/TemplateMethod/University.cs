using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Pass entrance exams and enter the university");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lectures");
            Console.WriteLine("Do practice task");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass the exam in the specialty");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Getting a diploma of higher education");
        }
    }
}
