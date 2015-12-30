using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dota2Helper.Models;

namespace Dota2Helper
{
    public class Context : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public Context()
            : base("localDota2helper")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}