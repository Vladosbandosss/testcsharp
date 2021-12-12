using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShooter
{
    class Enemy : Person
    {

        private int _health;
        private int _damage = 5;

        public Enemy(int health) : base(health)
        {
            _health = health;
        }

        public int GetHealth()
        {
            return _health;
        }

        public override void DisplayChoiseInfo()
        {
            Console.WriteLine("У врага " + _health + "здоровья");
        }

        public override void Attack(Person person)
        {
            person.TakeDamage(_damage);
        }

        public override void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                Console.WriteLine("игрок умер");
                return;
            }

          
        }
    }
}
