namespace TestesUnitarios
{
    public class BankAccount
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public decimal Balance { get; set; }
        public void Deposit(decimal value)
        {
            Balance += value;
        }
        public bool Draw(decimal value)
        {
            if (Balance < value) return false;
            else
            {
                Balance -= value;
                return true;
            }
        }

    }
}