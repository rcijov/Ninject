using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Interception;

namespace Examples.DependancyInjection
{
    public class OS : ICourse, IGraduate
    {
        public OS(ITeacher te, DayPeriod time)
        {
            Console.Out.Write("Create OS Course object : ");
            Console.Out.WriteLine(time);
            gradCourse = true;
        }

        [Inject]
        public ITeacher teacher { get; set; }
        public bool gradCourse { get; set; }

        public void ToString()
        {
            var str = "print OS Course";
            Console.Out.WriteLine(str);
            teacher.ToString();
        }
    }
}
