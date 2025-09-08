namespace PasswordCheckerService.Tests;

[TestFixture]
public class PasswordCheckerServiceTests
{
    private PasswordChecker _service;

    [SetUp]
    public void Setup()
    {
        _service = new PasswordChecker();
    }

    [TestCase("")]
    [TestCase("P")]
    [TestCase("Pa")]
    [TestCase("Pas")]
    [TestCase("Pass")]
    [TestCase("Password123")]
    [TestCase("Password1234")]
    [TestCase("Password1234567890")]
    public void Negative_Test(string password)
    {
        Assert.Throws<ArgumentException>(() => _service.CheckPassword(password));
    }

    [TestCase("Passw")]
    [TestCase("Passwo")]
    [TestCase("Password")]
    [TestCase("Password1")]
    [TestCase("Password12")]
    public void Positive_Test(string password)
    {
        Assert.DoesNotThrow(() => _service.CheckPassword(password));
    }
}
