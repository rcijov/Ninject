using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public class Dan : ITeacher
    {
        public Dan()
        {
            Console.Out.WriteLine("Create Dan Teacher object");
        }
        public void ToString()
        {
            var str = "print Dan Teacher";
            Console.Out.WriteLine(str);


        }
    }
}
