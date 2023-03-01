using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Earbud
    {
        private EarbudState State = new Off();

        public void TurnOn()
        {
            State.TurnOn(this);
        }

        public void TurnOff()
        {
            State.TurnOff(this);
        }

        public void PlayMusic()
        {
            State.PlayMusic(this);
        }
    }
}
