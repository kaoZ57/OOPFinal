using System;

namespace OOPFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.AddPlayer(new Player("Kao"));
            game.Play();

            Console.ReadKey();
        }
    }
}
