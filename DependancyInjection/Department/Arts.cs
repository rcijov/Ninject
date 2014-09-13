using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Examples.DependancyInjection
{
    public class Arts : IDepartment 
    {

        public Arts()
        {
            Console.Out.WriteLine("-----------------------------------------");
            Console.Out.WriteLine("Create Art Department object");
        }

        [Inject]
        public IEnumerable<ICourse> courses { get; set; }
        public void ToString()
        {
            var str = "print Art Department";
            Console.Out.WriteLine(str);
            foreach (ICourse c in courses)
            {
                c.ToString();
            }
            //courses.First().ToString();
        }
    }
}
