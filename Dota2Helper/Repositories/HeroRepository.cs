using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Dota2Helper.Models;

namespace Dota2Helper.Repositories
{
    public class HeroRepository
    {
        private readonly Context _context;

        public HeroRepository()
        {
            _context = new Context();
        }

        public async Task<ICollection<Hero>> GetAllAsync()
        {
            return await _context.Heroes.Include(n => n.Skills).ToListAsync();
        }

        //public async Task<ICollection<Hero>> GetAllWithoutIncludeAsync()
        public  ICollection<Hero> GetAllWithoutIncludeAsync()
        {
            //return await _context.Heroes.ToListAsync();
            return _context.Heroes.ToList();
        }

        public async Task<Hero> GetHeroByIdAsync(int id)
        {
            return await _context.Heroes.FirstOrDefaultAsync(n => n.Id == id);
        }

        //public async Task<Hero> GetHeroByNameAsync(string name)
        public  Hero GetHeroByNameAsync(string name)
        {
            //return await _context.Heroes.FirstOrDefaultAsync(n => n.Name == name);
            return _context.Heroes.FirstOrDefault(n => n.Name == name);
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