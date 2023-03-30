// Jeremy Fischer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class Monster
    {
        public string Name
        {
            get; set;
        }

        public int X
        {
            get; set;
        }

        public int Y
        {
            get; set;
        }

        public abstract int HitPoint 
        {
            get;
        }

        public abstract int ArmorClass
        {
            get;
        }

        public abstract int Speed
        {
            get;
        }

        public abstract double Attack
        {
            get;
        }

        public abstract double Damage
        {
            get;
        }
    }
}
