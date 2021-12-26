namespace RealExample.Leafs
{
    public class LeafAssestAccount : Composit
    {
        // in leaf class we just show the accounts with out any other operations.
        public string _AccountName { get; }
        public int _Id { get; }
        public LeafAssestAccount(string AccountName, int Id)
        {
            _Id = Id;
            _AccountName = AccountName;

        }
        public void print()
        {
            System.Console.WriteLine("The account name is : "+_AccountName +" the account code : "+_Id);
        }
    }
}