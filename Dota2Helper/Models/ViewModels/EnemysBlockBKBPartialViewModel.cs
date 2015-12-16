using System.Collections.Generic;

namespace Dota2Helper.Models.ViewModels
{
    public class EnemysBlockBKBPartialViewModel
    {
        public List<EnemyBlockBKBViewModel> Enemys { get; set; }

        public EnemysBlockBKBPartialViewModel()
        {
            Enemys = new List<EnemyBlockBKBViewModel>
            {
                new EnemyBlockBKBViewModel(),
                new EnemyBlockBKBViewModel(),
                new EnemyBlockBKBViewModel(),
                new EnemyBlockBKBViewModel(),
                new EnemyBlockBKBViewModel()
            };
        }
    }
}