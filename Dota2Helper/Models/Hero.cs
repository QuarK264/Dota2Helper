using System.Collections.Generic;

namespace Dota2Helper.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}