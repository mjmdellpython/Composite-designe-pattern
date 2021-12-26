namespace RealExample.Leafs
{
    public class LeafLiabilitiesAccounts : Composit
    {
        // in leaf class we just show the accounts with out any other operations.
        public string _AccountName { get; }
        public int _Id { get; }
        public LeafLiabilitiesAccounts(string AccountName, int Id)
        {
            this._AccountName = AccountName;
            this._Id = Id;

        }
        
        
        public void print()
        {
            System.Console.WriteLine("The account name is : "+_AccountName +" the account code : "+_Id);
        }
    }
}