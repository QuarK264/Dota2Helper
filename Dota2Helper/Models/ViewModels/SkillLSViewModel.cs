using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Helper.Models.ViewModels
{
    public class SkillLSViewModel
    {
        public string SkillName { get; set; }
        public byte PoolNumber { get; set; }
        public bool BlockLS { get; set; }
        public string CommentLS { get; set; }
        public string ImageLink { get; set; }
    }
}