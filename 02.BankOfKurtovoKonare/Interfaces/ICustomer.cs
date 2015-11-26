namespace _02.BankOfKurtovoKonare.Interfaces
{
    public interface ICustomer
    {
        string Name { get; }

        int DepositRateMinDuration { get; }

        int MortgageRateMinDuration { get; }
    }
}