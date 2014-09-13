using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Examples.DependancyInjection
{
    public class ComputerScience : IDepartment
    {
        public ComputerScience()
        {
            Console.Out.WriteLine("-----------------------------------------");
            Console.Out.WriteLine("Create Computer Science Department object");
        }

        [Inject]
        public IEnumerable<ICourse> courses { get; set; }

        public void ToString()
        {
            var str = "print Computer Science Department";
            Console.Out.WriteLine(str);
            foreach (ICourse c in courses)
            {
                c.ToString();
            }
        }
    }
}
