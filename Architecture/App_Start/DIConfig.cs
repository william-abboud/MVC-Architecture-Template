using System.Net;
using System.Reflection;
using System.Web.Mvc;
using Architecture.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace Architecture.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using SimpleInjector;

    public static class DIConfig
    {
        private static void RegisterServices(Container container)
        {
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>());
            container.Register<IAuthenticationManager>(() => HttpContext.Current.GetOwinContext().Authentication);
        }

        public static void RegisterSimpleInjector()
        {
            var container = new SimpleInjector.Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            RegisterServices(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}