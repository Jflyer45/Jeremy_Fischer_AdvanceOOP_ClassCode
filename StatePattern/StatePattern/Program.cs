using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            VendingMachine myMachine = new VendingMachine();
            myMachine.InsertCoin();
            myMachine.EjectCoin();
            myMachine.InsertCoin();
            myMachine.SelectItem();
            myMachine.DispenseItem();



        }
    }
}
