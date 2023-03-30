// Jeremy Fischer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class MonsterFactory
    {
        protected abstract Monster CreateMonster();

        public Monster MakeMonster()
        {
            Monster monster = CreateMonster();

            Random rnd = new Random();
            monster.Y = rnd.Next(1, 100);
            monster.X = rnd.Next(1, 100);

            return monster;
        }
    }
}
