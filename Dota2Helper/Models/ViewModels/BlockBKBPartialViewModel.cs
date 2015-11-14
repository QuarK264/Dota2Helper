using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Helper.Models.ViewModels
{
    public class BlockBKBPartialViewModel
    {
        public string SkillName { get; set; }
        public byte PoolNumber { get; set; }
        public bool BlockBKB { get; set; }
        public string CommentBKB { get; set; }
        public string ImageLink { get; set; }
    }
}