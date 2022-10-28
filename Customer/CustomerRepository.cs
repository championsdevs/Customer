using System.Diagnostics.CodeAnalysis;

namespace Customer
{
    [ExcludeFromCodeCoverage]
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<CustomerEntity> _customers = new();

        public void AddCustomer(CustomerEntity customer)
        {
            _customers.Add(customer);
        }

        public List<CustomerEntity> GetAllCustomers()
        {
            return _customers;
        }
    }
}
