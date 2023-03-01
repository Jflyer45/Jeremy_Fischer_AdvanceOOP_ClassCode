using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Off : EarbudState
    {
        public override void PlayMusic(Earbud earbud)
        {
            throw new NotImplementedException();
        }

        public override void TurnOff(Earbud earbud)
        {
            throw new NotImplementedException();
        }

        public override void TurnOn(Earbud earbud)
        {
            throw new NotImplementedException();
        }
    }
}
