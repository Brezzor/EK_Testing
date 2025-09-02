using NUnit.Framework;
using NUnit.Framework.Legacy;

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

    [TestCase(100, 0.2)]
    public void Test1(int amount, double expectedDiscount)
    {
        Assert.That(_service.CalculateDiscount(amount), Is.EqualTo(expectedDiscount));
    }
}
