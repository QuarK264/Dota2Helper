using System.Linq;
using System.Web.Mvc;
using Dota2Helper.Models;
using Dota2Helper.Models.ViewModels;
using Dota2Helper.Repositories;

namespace Dota2Helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly HeroRepository _heroRepository = new HeroRepository();

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel
            {
                HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Select(n => n.Name).OrderBy(n => n).ToList()
                //HeroNames = _heroRepository.GetAllWithoutIncludeAsync().Result.Select(n => n.Name).OrderBy(n => n).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult ShowEnemySkillsBKB(string[] heroNames)
        {
            EnemysBlockBKBPartialViewModel skills = new EnemysBlockBKBPartialViewModel();
            Hero hero;
            for (int i = 0; i < heroNames.Length; i++)
            {
                hero = _heroRepository.GetHeroByNameAsync(heroNames[i]);
                skills.Enemys[i] = new EnemyBlockBKBViewModel();
                for (int j = 0; j < hero.Skills.Count; j++)
                {
                    skills.Enemys[i].EnemySkills[j].SkillName = hero.Skills.ToList()[j].SkillName;
                    skills.Enemys[i].EnemySkills[j].ImageLink = hero.Skills.ToList()[j].ImageLink;
                    skills.Enemys[i].EnemySkills[j].BlockBKB = hero.Skills.ToList()[j].BlockBKB;
                    skills.Enemys[i].EnemySkills[j].CommentBKB = hero.Skills.ToList()[j].CommentBKB;
                    skills.Enemys[i].EnemySkills[j].PoolNumber = hero.Skills.ToList()[j].PoolNumber;
                }
            }
            return PartialView(skills);
        }

        [HttpPost]
        public ActionResult ShowEnemySkillsLS(string[] heroNames)
        {
            EnemysBlockLSPartialViewModel skills = new EnemysBlockLSPartialViewModel();
            Hero hero;
            for (int i = 0; i < heroNames.Length; i++)
            {
                hero = _heroRepository.GetHeroByNameAsync(heroNames[i]);
                skills.Enemys[i] = new EnemyBlockLSViewModel();
                for (int j = 0; j < hero.Skills.Count; j++)
                {
                    skills.Enemys[i].EnemySkills[j].SkillName = hero.Skills.ToList()[j].SkillName;
                    skills.Enemys[i].EnemySkills[j].ImageLink = hero.Skills.ToList()[j].ImageLink;
                    skills.Enemys[i].EnemySkills[j].BlockLS = hero.Skills.ToList()[j].BlockLS;
                    skills.Enemys[i].EnemySkills[j].CommentLS = hero.Skills.ToList()[j].CommentLS;
                    skills.Enemys[i].EnemySkills[j].PoolNumber = hero.Skills.ToList()[j].PoolNumber;
                }
            }
            return PartialView(skills);
        }
    }
}