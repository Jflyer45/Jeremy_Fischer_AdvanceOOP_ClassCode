using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CoinInserted : State
    {
        public override void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("You cannot input a second coin");
        }

        public override void EjectCoin(VendingMachine context)
        {
            Console.WriteLine("Coin Returned");
        }

        public override void InsertCoin(VendingMachine context)
        {
            Console.WriteLine("Your item is selected.");
        }

        public override void SelectItem(VendingMachine context)
        {
            Console.WriteLine("You must select an item first");
        }
    }
}
