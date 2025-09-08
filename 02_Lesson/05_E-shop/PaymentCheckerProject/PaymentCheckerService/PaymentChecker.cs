namespace PaymentCheckerService;

public class PaymentChecker
{
    public decimal CheckPayment(decimal amount)
    {
        decimal _amount = decimal.Round(amount, 2);

        if (_amount < 0.01m)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be larger than 0.01.");
        }
        else if (_amount <= 300.00m)
        {
            return _amount;
        }
        else if (_amount <= 800.00m)
        {
            return decimal.Round(_amount * 0.95m, 2);
        }
        else
        {
            return decimal.Round(_amount * 0.9m, 2);
        }
    }
}
