using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFinal
{
    interface IAction
    {
        void Attack();

        void Defend();

        void Move();
    }

    abstract class Character : IAction
    {
        public string Name { get; set; }
        public abstract void Attack();
        public virtual void Defend()
        {   
            Console.Write("Defend");
        }
        public void Move()
        {
            Console.Write("{0} Move", Name);
        }
    }

    class Assasin : Character 
    {
        public Assasin()
        {
            this.Name = "Assasin";
        }

        public override void Attack()
        {
            Console.Write("Fencing");
        }
    }

    class Destroyer : Character 
    {
        public Destroyer()
        {
            this.Name = "Destroyer";
        }
        public override void Attack()
        {
            Console.Write("Smash");
        }
    }

    class Archer : Character 
    {
        public Archer()
        {
            this.Name = "Archer";
        }
        public override void Attack()
        {
            Console.Write("Shoot a bow");
        }
    }
}
