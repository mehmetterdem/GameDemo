using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService

    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamer(gamer))
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                throw new Exception("not a valid person");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }
    }
}
