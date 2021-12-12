using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShooter
{
    class Player : Person
    {
        private int _health;

        private int _damageToEnemy;

        public Player(int health) : base(health)
        {
            _health = health;
        }

        public override void DisplayChoiseInfo()
        {
            Console.WriteLine("выбери оружие которым будем атаковать 1-пистолет,2-автомат");
            string weaponName = Console.ReadLine();
            int choise;
            bool result = int.TryParse(weaponName, out choise);
            int damageToEnemy;

            if (result)
            {
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("буду атокавать пистолетом");
                        damageToEnemy = 10;
                        break;
                    case 2:
                        Console.WriteLine("буду атаковать автоматом");
                        damageToEnemy = 20;
                        break;
                    default:
                        damageToEnemy = 0;
                        Console.WriteLine("я не понял что ты выбрал пропущу");

                        break;
                }

                _damageToEnemy = damageToEnemy;

            }
        }

        public override void Attack(Person person)
        {
            DisplayChoiseInfo();
            person.TakeDamage(_damageToEnemy);
            person.DisplayChoiseInfo();
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
