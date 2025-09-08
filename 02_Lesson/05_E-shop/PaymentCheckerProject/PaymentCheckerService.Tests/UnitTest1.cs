namespace PaymentCheckerService.Tests;

public class Tests
{
    private PaymentChecker _paymentChecker;

    [SetUp]
    public void Setup()
    {
        _paymentChecker = new PaymentChecker();
    }

    [TestCase(0.00, typeof(ArgumentOutOfRangeException))]
    public void Test1(decimal amount, Type expectedException)
    {
        Assert.Throws(expectedException, () => _paymentChecker.CheckPayment(amount));
    }

    [TestCase(0.01, 0.01)]
    [TestCase(0.02, 0.02)]
    [TestCase(151.00, 151.00)]
    [TestCase(299.99, 299.99)]
    [TestCase(300.00, 300.00)]
    [TestCase(300.01, 285.01)]
    [TestCase(300.02, 285.02)]
    [TestCase(550.05, 522.55)]
    [TestCase(799.99, 759.99)]
    [TestCase(800.00, 760.00)]
    [TestCase(800.01, 720.01)]
    [TestCase(800.02, 720.02)]
    [TestCase(1500.00, 1350.00)]
    public void Test2(decimal amount, decimal expectedResult)
    {
        Assert.That(_paymentChecker.CheckPayment(amount), Is.EqualTo(expectedResult));
    }
}
