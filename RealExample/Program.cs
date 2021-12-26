using System;
using RealExample.Component;
using RealExample.Leafs;

namespace RealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello composit Pattern!");

            LeafAssestAccount laa = new LeafAssestAccount("Building", 111);
            LeafLiabilitiesAccounts lba = new LeafLiabilitiesAccounts("paypal", 211);

            ComponentManager cm = new ComponentManager();
            cm.AddAccount(laa);
            cm.AddAccount(lba);

            ComponentManager cmp = new ComponentManager();//to aggregate all addition option in one object
            cmp.AddAccount(cm);

            cmp.print();
            //cm.print();
        }
    }
}
