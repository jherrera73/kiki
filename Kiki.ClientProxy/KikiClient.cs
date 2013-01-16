
using System.ServiceModel;
using Kiki.ServiceModel.Contracts;

namespace Kiki.ClientProxy
{
    public class KikiClient : ClientBase<IKikiService>, IKikiService
    {
        public string LetsHaveAKiki()
        {
            return Channel.LetsHaveAKiki();
        }
    }
}
