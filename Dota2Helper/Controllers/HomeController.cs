using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dota2Helper.Models.ViewModels;
using Dota2Helper.Repositories;
using Dota2Helper.Models;

namespace Dota2Helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly HeroRepository _heroRepository = new HeroRepository();
        private readonly HeroRepository _heroRepository = new HeroRepository();

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            //model.HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Result.Select(n => n.Name).ToList();
            model.HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Select(n => n.Name).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult ShowEnemySkillsBKB(string[] names)
        {
            List<BlockBKBPartialViewModel> skills = new List<BlockBKBPartialViewModel>();
            foreach (var name in names)
            {
                skills.Add(_heroRepository.GetHeroByNameAsync(name));
            }
            return PartialView(skills);
        }
    }
}