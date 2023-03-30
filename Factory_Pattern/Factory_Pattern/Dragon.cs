using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Dragon : Monster
    {
        public override int HitPoint
        {
            get { return 15; }
        }

        public override int ArmorClass
        {
            get { return 115; }
        }

        public override int Speed
        {
            get { return 310; }
        }

        public override double Attack
        {
            get { return 210; }
        }

        public override double Damage
        {
            get { return 11; }
        }
    }
}
