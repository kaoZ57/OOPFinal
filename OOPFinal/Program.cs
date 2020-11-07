using System;

namespace OOPFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.Write("Enter name =");
            string name = Console.ReadLine();

            game.AddPlayer(new Player(name));
            game.Play();

            Console.ReadKey();
        }
    }
}
