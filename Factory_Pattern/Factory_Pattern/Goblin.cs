using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Goblin : Monster
    {

        public override int HitPoint
        {
            get { return 5; }
        }

        public override int ArmorClass
        {
            get { return 15; }
        }

        public override int Speed
        {
            get { return 30; }
        }

        public override double Attack
        {
            get { return 20; }
        }

        public override double Damage
        {
            get { return 1; }
        }
    }
}
