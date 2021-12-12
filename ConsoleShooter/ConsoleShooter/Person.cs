using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShooter
{
    abstract class Person
    {
        public int Health { get; set; }

        public Person(int health)
        {
            Health = health;
        }

        public abstract void DisplayChoiseInfo();

        public abstract void Attack(Person person);

        public abstract void TakeDamage(int damage);
        

     
    }
}
