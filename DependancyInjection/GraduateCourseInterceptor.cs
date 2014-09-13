using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Interception;

namespace Examples.DependancyInjection
{
    public class GraduateCourseInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {

                var target = invocation.Request.Target;
                string courseName = invocation.Request.Target.GetType().Name.ToString();

                // If the course has a Graduate Interface, send a message
                if (target.GetType().GetInterface("IGraduate") != null)
                {
                    LogMessage(courseName);
                }

                //run the intercepted method
                invocation.Proceed();

            }
            catch (Exception ex)
            {
                var message = string.Format("EXCEPTION occured: {0} ", ex);
                LogMessage(message);
                throw;
            }
        }

        private static void LogMessage(string message)
        {
            Console.WriteLine(string.Format("<-- Graduate Course {0} -->",  message));
        }
    }
}
