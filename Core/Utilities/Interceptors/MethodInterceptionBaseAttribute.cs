using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    //koddu çağırdığımda üstüne baktıgında benim koydugum attribute yapısı çalışaack demek 
     
    //program içiçnde  attribute yapısını kullanabilmek içinn kurduğum yapı 
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    //class yada methotlara ekleyebiliirm bu yapıyı  ,birden fazla yerde ,birden fazla kullanabilirm ve inherite edilen yerde çalışşın 
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } //attrıbutelerin oncelik sırasını belirtmek için

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
//bu aop yapısını sağlayacak olan autofac paketlerimi kurdum 