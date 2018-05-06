using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDependencyInjectionOnMVC.Infrastructure;
using UnityDependencyInjectionOnMVC.Services;

namespace UnityDependencyInjectionOnMVC.App_Start
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<ILocalWeatherServiceProvider, LocalWeatherServiceProvider>();
            container.RegisterType<IFacebookConnectionManager, FacebookConnectionManager>
                (new InjectionConstructor(
                    ConfigurationManager.AppSettings["username"],
                    ConfigurationManager.AppSettings["authenticationToken"],
                    ConfigurationManager.AppSettings["facebookUrl"]
                    ));
        }
    }
}