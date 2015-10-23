using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Helper.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Desc { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}