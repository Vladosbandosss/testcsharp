using System;

namespace ConsoleShooter
{
    class Program
    {
        static void Main(string[] args)
        {

            bool canFight = true;

            Enemy enemy = new Enemy(100);
            Player player = new Player();

            while (canFight)
            {
                player.Attack(enemy);

                if (enemy.GetHealth() <= 0)
                {
                    canFight = false;
                }
            }

            Console.WriteLine("Бой окончен");

           
            
        }
    }
}
