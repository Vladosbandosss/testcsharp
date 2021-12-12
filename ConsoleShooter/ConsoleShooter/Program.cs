using System;

namespace ConsoleShooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helo");
           

            Enemy enemy = new Enemy(100);
           Player player = new Player(100);

            Arena arena = new Arena(player,enemy);
            arena.Fight();
            


           
            
        }
    }
}
