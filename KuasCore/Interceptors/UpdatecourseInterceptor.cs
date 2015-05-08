using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;
using KuasCore.Models;
using System.Diagnostics;

namespace KuasCore.Interceptors
{
    class UpdatecourseInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {

            Console.WriteLine("UpdatecourseInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdatecourseInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is course)
            {
                course course = (course)result;
                course.course_name = course.course_name + " 超夯學程";
                result = course;
            }

            return result;
        }
    }
}
