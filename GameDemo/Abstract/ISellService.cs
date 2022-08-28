using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface ISellService
    {
        void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}
