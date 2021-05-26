using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResoivers.Autofac
{

   public class AutofacBusinessModule :Module
    {
        //autofacde instens geliştirme şekli 
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();




            builder.RegisterType<DietManager>().As<IDietService>().SingleInstance();
            builder.RegisterType<EfDietDal>().As<IDietDal>().SingleInstance();


            builder.RegisterType<DiseaseManager>().As<IDietService>().SingleInstance();
            builder.RegisterType<EfDiseaseDal>().As<IDiseaseDal>().SingleInstance();


            builder.RegisterType<PatientManager>().As<IPatientService>().SingleInstance();
            builder.RegisterType<EfPatientDal>().As<IPatientDal>().SingleInstance();


            //kayıt ettiğm sınıflar için  ınterseptr  ozelliği sağlıyor .
            //çalışan uygulam içereisidende  implemente edilmiş interfaces leri buluyor ve onlarıa  onlar için olusturdugum aspect yapısının çağrıyor 

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }

        //kısacası ben autofac mimarisi ile metodumun aspectlerini çalıştırmış oldum 
    }
}
