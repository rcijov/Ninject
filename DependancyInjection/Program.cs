using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using System.Reflection;

namespace Examples.DependancyInjection
{
    public enum DayPeriod { morning, afternoon, night }

    class Program
    {
        static void Main(string[] args)
        {
            // create a Ninject kernel to resolve dependancies in our code automatically
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            ISchool school = kernel.Get<ISchool>();

            school.ToString();

            Console.ReadLine();
        }
    }
}
