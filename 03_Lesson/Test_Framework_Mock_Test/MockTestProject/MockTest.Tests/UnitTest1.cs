using Moq;

namespace MockTest.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        // Arrange
        var customerId = 1;
        var expectedCustomer = new Customer
        {
            Id = 1,
            Name = "John Doe",
            Email = "John.Doe@Test.com",
            PhoneNumber = "123-456-7890"
        };

        Mock<ICusomerRepository> _mockCustomerRepository = new Mock<ICusomerRepository>();

        _mockCustomerRepository
            .Setup(repo => repo.GetCustomerById(customerId))
            .Returns(expectedCustomer);

        var customerService = new CustomerService(_mockCustomerRepository.Object);

        // Act
        var actualCustomer = customerService.GetCustomer(customerId);

        // Assert
        Assert.That(actualCustomer, Is.EqualTo(expectedCustomer));
    }
}
