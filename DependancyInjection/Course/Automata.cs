using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Examples.DependancyInjection
{
    public class Automata : ICourse, IGraduate
    {

        public Automata( ITeacher te, DayPeriod time)
        {
            Console.Out.Write("Create Automata Course object : ");
            Console.Out.WriteLine(time);
            gradCourse = false;
        }

        [Inject]
        public ITeacher teacher { get; set; }
        public bool gradCourse { get; set; }
        

        public void ToString()
        {
            var str = "print Automata Course";
            Console.Out.WriteLine(str);
            teacher.ToString();
        }
    }
}
