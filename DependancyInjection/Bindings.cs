using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;

namespace Examples.DependancyInjection
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISchool>().To<Concordia>().InSingletonScope();
           
            Bind<ITeacher>().To<Julia>().WhenInjectedInto<Painting>().InSingletonScope();
            Bind<ITeacher>().To<Dan>().WhenInjectedInto<OS>().InSingletonScope();
            Bind<ITeacher>().To<Dan>().WhenInjectedInto<Automata>().InSingletonScope();

            Bind<IDepartment>().To<ComputerScience>().Named("CS");
            Bind<IDepartment>().To<Arts>().Named("Arts");
            Bind<ICourse>().To<Painting>().WhenParentNamed("Arts").WithConstructorArgument("time", DayPeriod.afternoon).Intercept().With<GraduateCourseInterceptor>();
            Bind<ICourse>().To<Automata>().WhenParentNamed("CS").WithConstructorArgument("time", DayPeriod.morning).Intercept().With<GraduateCourseInterceptor>();
            Bind<ICourse>().To<OS>().WhenParentNamed("CS").WithConstructorArgument("time", DayPeriod.night).Intercept().With<GraduateCourseInterceptor>();

        }
    }
}
