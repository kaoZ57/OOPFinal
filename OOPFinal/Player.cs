using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFinal
{
    class Player
    {
        private string Name;
        private List<Character> characterslist = new List<Character>();

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
            foreach (var C in characterslist)
            {
                C.Attack();
                C.Eat();
            }
        }
    }
}
