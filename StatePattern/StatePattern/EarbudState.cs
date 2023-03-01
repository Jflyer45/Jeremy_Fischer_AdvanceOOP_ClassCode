using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class EarbudState
    {
        public abstract void TurnOn(Earbud earbud);
        public abstract void TurnOff(Earbud earbud);
        public abstract void PlayMusic(Earbud earbud);

    }
}
