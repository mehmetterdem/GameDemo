using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class SellManager : ISellService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " adlı oyunu " + campaign.CampaignName + " kampanyası ile " +
                game.GamePrice + " TL yerine " + game.GameDiscountPrice + " TL ye satın aldınız.");
        }
    }
}
