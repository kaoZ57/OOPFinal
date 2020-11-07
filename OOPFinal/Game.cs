using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOPFinal
{
    class Game 
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void Play()
        {
            ShowProgress();
            foreach (var P in players)
            {
                Console.WriteLine(P.Getname);
                P.AddCharacter(new Assasin());
                P.AddCharacter(new Destroyer());
                P.AddCharacter(new Archer());
                P.charactersAttack();
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
