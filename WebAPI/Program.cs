using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResoivers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }


            //kendi IOC YAPIMIZ ÝÇÝN AUTOFAC E GEÇTÝM oNU KULLANACAÐIMI PROGRAM CS YE bELÝRTTÝM
            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                  .ConfigureContainer<ContainerBuilder>(builder =>
                  {
                      builder.RegisterModule(new AutofacBusinessModule());
                  })
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });
        }

    }

