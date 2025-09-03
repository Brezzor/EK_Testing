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
    public void Test1(string password)
    {
        Assert.Throws<ArgumentException>(() => _service.CheckPassword(password));
    }
}
