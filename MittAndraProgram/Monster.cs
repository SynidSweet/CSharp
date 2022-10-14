using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittAndraProgram
{
    class Monster
    {
        private static Random random = new Random();

        public string type;
        public string name;
        public int hp;
        public int level;

        public Monster()
        {
            type = "Skeleton";
            name = "Argur";
            hp = 10;
            level = 2;
        }

        public int AttackDamage()
        {
            int damage = random.Next(1, 10) + level;
            return damage;
        }

        public void TakeDamage(int damage)
        {
            hp = hp - damage;
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
    }
}
