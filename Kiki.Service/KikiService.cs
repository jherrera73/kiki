
using System;
using System.Collections.Generic;
using System.Linq;
using Kiki.Infrastructure.Contexts;
using Kiki.ServiceModel.Contracts;

namespace Kiki.Service
{
    public class KikiService : IKikiService
    {
        private KikiContext _kikiContext;

        public KikiService(KikiContext kikiContext)
        {
            _kikiContext = kikiContext;
        }

        public string LetsHaveAKiki()
        {
            List<Infrastructure.Models.Kiki> kikis = _kikiContext.Kikis.ToList();

            if (kikis.Count == 0) return "";

            Random random = new Random();

            int randomNumber = random.Next(0, kikis.Count);

            return kikis[randomNumber].Saying;

        }
    }
}
