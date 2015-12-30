namespace Dota2Helper.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public byte PoolNumber { get; set; }
        public bool BlockBKB { get; set; }
        public bool BlockLS { get; set; }
        public string CommentBKB { get; set; }
        public string CommentLS { get; set; }
        public string ImageLink { get; set; }

        public int HeroId { get; set; }
        public virtual Hero Hero { get; set; }
    }
}