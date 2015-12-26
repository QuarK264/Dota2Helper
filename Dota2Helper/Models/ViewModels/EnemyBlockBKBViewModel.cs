using System.Collections.Generic;

namespace Dota2Helper.Models.ViewModels
{
    public class EnemyBlockBKBViewModel
    {
        public List<SkillBKBViewModel> EnemySkills { get; set; }

        public EnemyBlockBKBViewModel()
        {
            EnemySkills = new List<SkillBKBViewModel>
            {
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel(),
                new SkillBKBViewModel()
            };
        }
    }
}