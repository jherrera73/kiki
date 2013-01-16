using System.Web.Mvc;
using Kiki.ClientProxy;
using Kiki.ServiceModel.Contracts;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Kiki.WebApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            container.RegisterType<IKikiService, KikiClient>();

            return container;
        }
    }
}