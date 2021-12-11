using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShooter
{
    class Enemy
    {
        private int _health = 100;

       
        public Enemy(int health)
        {
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                Console.WriteLine("игрок умер");
                return;
            }

            else
            {
                Console.WriteLine("у меня " + _health + " здоровья");
            }
        }

        public int GetHealth()
        {
            return _health;
        }
    }
}
