namespace PrinterCartridgeService.Tests;

[TestFixture]
public class PrinterCartridgeServiceTests
{
    private PrinterCartridgeDiscount _service;

    [SetUp]
    public void Setup()
    {
        _service = new PrinterCartridgeDiscount();
    }

    [TestCase(5, 0)]
    [TestCase(6, 0)]
    [TestCase(47, 0)]
    [TestCase(98, 0)]
    [TestCase(99, 0)]
    [TestCase(100, 0.2)]
    [TestCase(101, 0.2)]
    [TestCase(167, 0.2)]
    public void Test1(int amount, double expectedDiscount)
    {
        Assert.That(_service.CalculateDiscount(amount), Is.EqualTo(expectedDiscount));
    }

    [TestCase(-15)]
    [TestCase(-2)]
    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    [TestCase(-10)]
    [TestCase(-167)]
    public void Test2(int amount)
    {
        var ex = Assert.Throws<ArgumentException>(() => _service.CalculateDiscount(amount));
        Assert.That(ex.Message, Is.EqualTo("The minimum order quantity is 5."));
    }
}
