using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class TrollFactory : MonsterFactory
    {
        protected override Monster CreateMonster()
        {
            return new Troll();
        }
    }
}
