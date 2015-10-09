using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Dota2Helper.Models.ViewModels;
using Dota2Helper.Repositories;

namespace Dota2Helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly HeroRepository _heroRepository;

        public HomeController(HeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel
            {
                HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Result.Select(n => n.Name).ToList()
            };
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}