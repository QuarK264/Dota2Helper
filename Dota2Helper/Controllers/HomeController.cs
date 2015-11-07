using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dota2Helper.Models.ViewModels;
using Dota2Helper.Repositories;

namespace Dota2Helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly HeroRepository _heroRepository = new HeroRepository();

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            //List<string> names = _heroRepository.GetAllWithoutIncludeAsync().Result.Select(n => n.Name).ToList();
            model.HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Select(n => n.Name).ToList();
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