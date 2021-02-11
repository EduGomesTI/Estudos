namespace Aula_125_Heranca.Entities
{
    sealed class SavingsAccount : Account //sealed proibe a criação de uma subclasse desta classe;
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //sealed impeder que um método sobreposto seja sobreposto novamente. Só funciona para métodos sobrepostos.
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
