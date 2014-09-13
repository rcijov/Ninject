using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Examples.DependancyInjection
{
    public class Concordia : ISchool
    {
        IDepartment department;
        public Concordia()
        {
            Console.Out.WriteLine("Create Concordia School object");
        }

        [Inject]
        public IEnumerable<IDepartment> departments { get; set; }

        public void ToString()
        {
            var str = "print Concordia School";
            Console.Out.WriteLine(str);
            foreach (IDepartment d in departments)
            {
                d.ToString();
            }
        }
    }
}
