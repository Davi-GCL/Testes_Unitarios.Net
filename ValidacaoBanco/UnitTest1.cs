using TestesUnitarios;

namespace ValidacaoBanco
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.2 , 1.2)]
        public void TestDeposit(decimal value, decimal final)
        {
            BankAccount account = new BankAccount();
            account.Deposit(value);

            Assert.Equal(final, account.Balance);
        }
    }
}