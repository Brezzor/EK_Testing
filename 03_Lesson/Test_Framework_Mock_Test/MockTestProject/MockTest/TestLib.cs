namespace MockTest;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}

public interface ICusomerRepository
{
    public Customer GetCustomerById(int id);
}

public class CustomerService
{
    private readonly ICusomerRepository _customerRepository;

    public CustomerService(ICusomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer GetCustomer(int id)
    {
        return _customerRepository.GetCustomerById(id);
    }
}