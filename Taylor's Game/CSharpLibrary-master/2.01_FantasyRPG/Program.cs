﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to the worst RPG you've ever played!");
            Console.WriteLine("What is your name, brave warrior?");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);

            Console.WriteLine($"\nWelcome to my world, {player.Name}.");
            player.Stats();

            //adventure loop
            while (true)
            {
                Console.WriteLine("\nAre you ready to fight a monster? Yes or No to quit");
                string battleReady = Console.ReadLine();
                int mobSpawn = rand.Next(2);
                if (battleReady.ToLower() == "yes")
                {
                    if (mobSpawn == 0)
                    {
                        Bat bat = new Bat();
                        bat.Announce();
                        Battle battle = new Battle(bat, player);
                        battle.Fight();
                    }
                    else
                    {
                        Ogre ogre = new Ogre();
                        ogre.Announce();
                        Battle battle = new Battle(ogre, player);
                        battle.Fight();
                    }

                }
                else
                {
                    break;
                }
            }
        }
    }
}
