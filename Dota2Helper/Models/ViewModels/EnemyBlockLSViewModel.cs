using System.Collections.Generic;

namespace Dota2Helper.Models.ViewModels
{
    public class EnemyBlockLSViewModel
    {
        public List<SkillLSViewModel> EnemySkills { get; set; }

        public EnemyBlockLSViewModel()
        {
            EnemySkills = new List<SkillLSViewModel>
            {
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel(),
                new SkillLSViewModel()
            };
        }
    }
}