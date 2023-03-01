using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ItemSold : State
    {
        public override void DispenseItem(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("The item is being dispensed");
        }

        public override void EjectCoin(VendingMachine context)
        {
            Console.WriteLine("You cannot get your money back while the machine is dispensing");
        }

        public override void InsertCoin(VendingMachine context)
        {
            Console.WriteLine("You cannot insert a coin while the machine is dispensing");
        }

        public override void SelectItem(VendingMachine context)
        {
            Console.WriteLine("You cannot select an item when the machine is already dispensing");
        }
    }
}
