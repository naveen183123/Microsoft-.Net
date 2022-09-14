using RestApi_SP.Models;

namespace RestApi_SP.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerByID(int id);
        Task<Customer> ADDEditCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);
    }
}