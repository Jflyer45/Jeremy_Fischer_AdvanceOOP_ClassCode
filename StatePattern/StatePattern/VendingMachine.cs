// Jeremy Fischer was here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class VendingMachine
    {
        private State state = new NoCoin();

        public VendingMachine()
        {

        }

        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void InsertCoin()
        {
            State.InsertCoin(this);
        }

        public void EjectCoin()
        {
            State.EjectCoin(this);
        }

        public void SelectItem()
        {
            State.SelectItem(this);
            State.DispenseItem(this);
        }

        public void DispenseItem()
        {
            State.DispenseItem(this);
        }
    }
}
