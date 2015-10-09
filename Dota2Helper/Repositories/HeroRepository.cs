using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Dota2Helper.Models;

namespace Dota2Helper.Repositories
{
    public class HeroRepository
    {
        private readonly Context _context;

        public HeroRepository(Context context)
        {
            _context = context;
        }

        public async Task<ICollection<Hero>> GetAllAsync()
        {
            return await _context.Heroes.Include(n => n.Skills).ToListAsync();
        }

        public async Task<ICollection<Hero>> GetAllWithoutIncludeAsync()
        {
            return await _context.Heroes.ToListAsync();
        }

        public async Task<Hero> GetHeroByIdAsync(int id)
        {
            return await _context.Heroes.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Hero> GetHeroByNameAsync(string name)
        {
            return await _context.Heroes.FirstOrDefaultAsync(n => n.Name == name);
        }

        public async Task<Hero> GetHeroByIdWithSkillsAsync(int id)
        {
            return await _context.Heroes.Include(n => n.Skills).FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Hero> GetHeroByNameWithSkillsAsync(string name)
        {
            return await _context.Heroes.Include(n => n.Skills).FirstOrDefaultAsync(n => n.Name == name);
        }
    }
}