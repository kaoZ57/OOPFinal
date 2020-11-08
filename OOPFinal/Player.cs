using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFinal
{
    class Player
    {
        private string Name;
        private List<Character> characterslist = new List<Character>();

        public List<Character> Getcharacter
        {
            get
            {
                return characterslist;
            }
        }

        public string Getname
        {
            get { return Name; } 
        }
        public Player(string name = "Unknow")
        {
            this.Name = name;
        }
        public void AddCharacter(Character character)
        {
            characterslist.Add(character);
        }
        public void charactersAttack()
        {
            Console.WriteLine("'Press Enter to Attack'");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                foreach (var C in characterslist)
                {
                    Console.Write(C.Name + " ");
                    C.Attack();
                    Console.WriteLine("");
                }
            }
            else
            {
                charactersAttack();
            }
            charactersAttack();
        }
    }
}
