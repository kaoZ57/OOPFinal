using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOPFinal
{
    class Game 
    {
        private Player players;

        public void AddPlayer(Player player)
        {
            this.players = player;
        }

        public void Play()
        {
            ShowProgress();
            Console.WriteLine("Name : {0}", players.Getname);
            CreateCharacter();
        }

        private void CreateCharacter()
        {
        UP:
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Assasin");
            Console.WriteLine("[2] Destroyer");
            Console.WriteLine("[3] Archer");
            Console.Write("Enter you number Character : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    players.AddCharacter(new Assasin());
                    players.charactersAttack();
                    break;
                case "2":
                    players.AddCharacter(new Destroyer());
                    players.charactersAttack();
                    break;
                case "3":
                    players.AddCharacter(new Archer());
                    players.charactersAttack();
                    break;
                default:
                    goto UP;
            }
        }


        private void ShowProgress()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("\x000DLoading {0}%", i);
            }
            Console.WriteLine("");
            Console.Clear();
        }
    }
}
