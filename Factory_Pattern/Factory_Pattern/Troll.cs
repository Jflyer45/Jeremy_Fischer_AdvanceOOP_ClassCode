using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Troll : Monster
    {
        public override int HitPoint
        {
            get { return 52; }
        }

        public override int ArmorClass
        {
            get { return 152; }
        }

        public override int Speed
        {
            get { return 320; }
        }

        public override double Attack
        {
            get { return 202; }
        }

        public override double Damage
        {
            get { return 12; }
        }
    }
}
