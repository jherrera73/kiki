
using System;
using Kiki.ServiceModel.Contracts;

namespace Kiki.Service
{
    public class KikiService : IKikiService
    {
        public string LetsHaveAKiki()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 2);

            return randomNumber == 0 ? "Let's have a kiki" : "No kiki for you";
        }
    }
}
