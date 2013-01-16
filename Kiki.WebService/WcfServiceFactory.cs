using Kiki.Infrastructure.Contexts;
using Kiki.Service;
using Kiki.ServiceModel.Contracts;
using Microsoft.Practices.Unity;
using Unity.Wcf;

namespace Kiki.WebService
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			// register all your components with the container here
            container
               .RegisterType<IKikiService, KikiService>()
               .RegisterType<KikiContext>(new HierarchicalLifetimeManager(), new InjectionConstructor("Data Source=JHERRERAW7-LT;Initial Catalog=Kiki;Integrated Security=True"));
        }
    }    
}