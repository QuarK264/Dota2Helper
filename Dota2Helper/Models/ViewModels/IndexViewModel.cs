using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Helper.Models.ViewModels
{
    public class IndexViewModel
    {
        public int HeroId { get; set; }
        public byte SkillPoolNumber { get; set; }
        public string ImageLink { get; set; }
    }
}