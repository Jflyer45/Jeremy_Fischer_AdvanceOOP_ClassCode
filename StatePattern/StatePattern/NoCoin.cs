using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoCoin : State
    {
        public override void DispenseItem(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("You havn't inserted any money");
        }

        public override void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("You havn't inserted any money");
        }

        public override void InsertCoin(VendingMachine context)
        {
            context.State = new CoinInserted();
            Console.WriteLine("Coin Selected pick a item");
        }

        public override void SelectItem(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("You havn't inserted any money");
        }
    }
}
