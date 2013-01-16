using System.Web.Mvc;
using Kiki.ServiceModel.Contracts;
using Kiki.WebApp.Models;

namespace Kiki.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly IKikiService _kikiService;

        public HomeController(IKikiService kikiService)
        {
            _kikiService = kikiService;
        }


        public ActionResult Index()
        {
            HomeIndexViewModel homeIndexViewmodel = new HomeIndexViewModel {KikiSaying = _kikiService.LetsHaveAKiki()};
            
            return View(homeIndexViewmodel);
        }

    }
}
