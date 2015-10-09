using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Dota2Helper.Models;

namespace Dota2Helper.Repositories
{
    public class SkillRepository
    {
        private readonly Context _context;

        public SkillRepository(Context context)
        {
            _context = context;
        }

        public async Task<ICollection<Skill>> GetAllAsync()
        {
            return await _context.Skills.Include(n => n.Hero).ToListAsync();
        }

        public async Task<ICollection<Skill>> GetAllWithoutIncludeAsync()
        {
            return await _context.Skills.ToListAsync();
        }

        public async Task<Skill> GetSkillByIdAsync(int id)
        {
            return await _context.Skills.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Skill> GetSkillByNameAsync(string name)
        {
            return await _context.Skills.FirstOrDefaultAsync(n => n.SkillName == name);
        }

        public async Task<Skill> GetSkillByIdWithHeroAsync(int id)
        {
            return await _context.Skills.Include(n => n.Hero).FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Skill> GetSkillByNameWithHeroAsync(string name)
        {
            return await _context.Skills.Include(n => n.Hero).FirstOrDefaultAsync(n => n.SkillName == name);
        }
    }
}