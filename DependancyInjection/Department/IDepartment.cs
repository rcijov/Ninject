using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public interface IDepartment
    {
        IEnumerable<ICourse> courses { get; set; }
        void ToString();
    }
}
