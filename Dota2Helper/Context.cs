using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Dota2Helper.Models;

namespace Dota2Helper
{
    public class Context : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public Context() : base("Context")
        {
            
        }
    }
}