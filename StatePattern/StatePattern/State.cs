using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class State
    {
        public abstract void InsertCoin(VendingMachine context);
        public abstract void EjectCoin(VendingMachine context);
        public abstract void SelectItem(VendingMachine context);
        public abstract void DispenseItem(VendingMachine context);
    }
}
