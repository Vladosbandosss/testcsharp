using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShooter
{
    class Arena
    {
        Person player;
        Person enemy;
        public Arena(Person person1,Person person2)
        {
            player = person1;
            enemy = person2;
        }

        public void Fight()
        {
            player.Attack(enemy);
        }
    }
}
