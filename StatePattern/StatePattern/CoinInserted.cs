﻿using System;
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
            context.State = new NoCoin();
            Console.WriteLine("You must select an item first");
        }

        public override void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("Coin Returned");
        }

        public override void InsertCoin(VendingMachine context)
        {
            context.State = new CoinInserted();
            Console.WriteLine("You cannot input a second coin");
            
        }

        public override void SelectItem(VendingMachine context)
        {
            context.State = new ItemSold();
            Console.WriteLine("Your item is selected.");
            
        }
    }
}
