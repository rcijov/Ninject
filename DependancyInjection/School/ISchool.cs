using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public interface ISchool
    {
        IEnumerable<IDepartment> departments { get; set; }

        void ToString();
    }
}
