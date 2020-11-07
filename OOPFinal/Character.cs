using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFinal
{
    abstract class Character : IAction
    {
        public abstract void Attack();
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }
    interface IAction
    {
        void Eat();
    }

    class Assasin : Character 
    {
        public override void Attack()
        {
            Console.WriteLine("Assasin Attack");
        }
    }
    class Destroyer : Character 
    {
        public override void Attack()
        {
            Console.WriteLine("Destroyer Attack");
        }
    }
    class Archer : Character 
    {
        public override void Attack()
        {
            Console.WriteLine("Archer Attack");
        }
    }
}
