using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittAndraProgram
{
    class Player
    {
        private static Random random = new Random();

        public int hp;
        public int level;
        public string name;
        public int gold;

        public Player(string name)
        {
            this.name = name;
            hp = 100;
            level = 1;
            gold = 0;
        }

        public void TakeDamage(int damage)
        {
            hp = hp - damage;
        }

        public int AttackDamage()
        {
            int damage = random.Next(1, 10) + level;
            return damage;
        }

        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StatusReport()
        {
            return $"{name} is level {level} with {hp} health.";
        }
    }
}
