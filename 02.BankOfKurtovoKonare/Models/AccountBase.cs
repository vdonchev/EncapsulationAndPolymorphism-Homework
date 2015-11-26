namespace _02.BankOfKurtovoKonare.Models
{
    using Interfaces;

    public abstract class AccountBase : IAccount, IDeposit
    {
        private decimal ballance;

        protected AccountBase(ICustomer customer, decimal ballance, double interesetrate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interesetrate;
        }

        public ICustomer Customer { get; }

        public decimal Ballance
        {
            get
            {
                return this.ballance;
            }

            protected set
            {
                Utils.Validator.IsNegative(value, "Initial ballance");
                this.ballance = value;
            }
        }

        public double InterestRate { get; }

        public void Deposit(decimal sum)
        {
            Utils.Validator.IsNegativeOrZero(sum, "Deposit sum");
            this.Ballance += sum;
        }

        public virtual decimal CalculateIntereset(int months) => 
            this.Ballance * (1 + (decimal)(this.InterestRate * months));

        public override string ToString() =>
            $"{this.Customer.Name} Ballance: {this.Ballance:C}";
    }
}