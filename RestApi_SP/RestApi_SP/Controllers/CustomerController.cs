using Microsoft.AspNetCore.Mvc;
using RestApi_SP.Models;
using RestApi_SP.Repository;

namespace RestApi_SP.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRep;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRep = customerRepository;
        }
        [HttpGet]
        public async Task<List<Customer>> GetCustomers()
        {
            return await _customerRep.GetCustomers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetByCustomerByID(int id)
        {
            return await _customerRep.GetCustomerByID(id);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> ADDEditCustomer([FromBody] Customer customer)
        {
            if (customer == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid State");
            }

            return await _customerRep.ADDEditCustomer(customer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteById(int id)
        {
            return await _customerRep.DeleteCustomer(id);
        }
    }
}
