using Moq;

namespace MockTest.Tests;

[TestFixture]
public class Tests
{
    private Mock<ICusomerRepository> _mockCustomerRepository;

    [SetUp]
    public void Setup()
    {
        _mockCustomerRepository = new Mock<ICusomerRepository>();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        var customerId = 1;
        var expectedCustomer = new Customer
        {
            Id = customerId,
            Name = "John Doe",
            Email = "John.Doe@Test.com",
            PhoneNumber = "123-456-7890"
        };

        _mockCustomerRepository
            .Setup(repo => repo.GetCustomerById(customerId))
            .Returns(expectedCustomer);

        var customerService = new CustomerService(_mockCustomerRepository.Object);

        // Act
        var actualCustomer = customerService.GetCustomer(customerId);

        // Assert
        Assert.That(actualCustomer, Is.Not.Null);
        Assert.That(expectedCustomer.Id, Is.EqualTo(actualCustomer.Id));
        Assert.That(expectedCustomer.Name, Is.EqualTo(actualCustomer.Name));
        Assert.That(expectedCustomer.Email, Is.EqualTo(actualCustomer.Email));
        Assert.That(expectedCustomer.PhoneNumber, Is.EqualTo(actualCustomer.PhoneNumber));

        _mockCustomerRepository
            .Verify(repo => repo.GetCustomerById(customerId), Times.Once, "GetCustomerById was not called exactly once.");
    }
}
