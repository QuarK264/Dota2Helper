using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Helper.Models.ViewModels
{
    public class EnemysBlockLSPartialViewModel
    {
        public List<EnemyBlockLSViewModel> Enemys { get; set; }

        public EnemysBlockLSPartialViewModel()
        {
            Enemys = new List<EnemyBlockLSViewModel>
            {
                new EnemyBlockLSViewModel(),
                new EnemyBlockLSViewModel(),
                new EnemyBlockLSViewModel(),
                new EnemyBlockLSViewModel(),
                new EnemyBlockLSViewModel()
            };
        }
    }
}