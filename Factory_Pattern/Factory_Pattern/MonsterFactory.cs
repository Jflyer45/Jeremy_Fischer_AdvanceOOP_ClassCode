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
        public abstract Monster CreateMonster();

        public void MakeMonster()
        {
            Monster monster = CreateMonster();

            Random rnd = new Random();
            monster.Y = rnd.Next(1, 100);
            monster.X = rnd.Next(1, 100);
        }
    }
}
