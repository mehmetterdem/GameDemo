using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Concrete;
using GameDemo.Entity;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager manager = new GamerManager(new GamerCheckManager ());

            manager.Add(new Gamer {
                FirstName = "mehmet",
                LastName = "Erdem",
                Id = 1,
                Birthday = new DateTime(1994,8,9),
                TcNo = "1111111111"
            });

        }

      
    }
}
