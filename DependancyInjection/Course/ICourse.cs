using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public interface ICourse
    {
        ITeacher teacher { get; set; }

        bool gradCourse { get; set; }

        void ToString();
    }
}
