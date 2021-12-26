using System.Collections.Generic;

namespace RealExample.Component
{
    public class ComponentManager:Composit
   {
       // in this class can generate for accounts list and manage it by deferent opreations.
        List<Composit> BalanceSheetAccounts = new List<Composit>();
        /*
        public string _Name { get; }
        private readonly int _Id;
        public ComponentManager(string Name, int Id)
        {
            _Id = Id;
            _Name = Name;

        }*/

        public void AddAccount(Composit acc)
        {
            BalanceSheetAccounts.Add(acc);
        }

        public void RemoveAccount(Composit acc)
        {
            BalanceSheetAccounts.Remove(acc);
        }

        public void print()
        {
            foreach (var item in BalanceSheetAccounts)
            {
                item.print();
            }
        }
    }
}