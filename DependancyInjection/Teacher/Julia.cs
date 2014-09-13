using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Examples.DependancyInjection
{
    public class Julia : ITeacher
    {
        public Julia()
        {
            Console.Out.WriteLine("Create Julia Teacher object");
        }
        public void ToString()
        {
            var str = "print Julia Teacher";
            Console.Out.WriteLine(str);


        }
    }
}
