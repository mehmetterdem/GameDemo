﻿using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    { 
        public void Add(Game game)
        {
            Console.WriteLine("Game Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Updated");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Deleted");
        }
    }
}
