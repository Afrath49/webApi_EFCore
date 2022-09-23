using Microsoft.AspNetCore.Mvc;
using webApi_EFCore.Models;

namespace webApi_EFCore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {


        private readonly Icustomer icustomer;
        public CustomerController(Icustomer customer)
        {
            this.icustomer = customer;
        }


        [HttpPost]
        public Task<Customer> AddCustomer(Customer customer)
        {
            Customer custom = icustomer.Add(customer);
            return Task.FromResult(custom);
        }

        [HttpGet]
        public Task<IEnumerable<Customer>> GetAllCustomer()
        {
           
           IEnumerable<Customer> custom = icustomer.GetAll();
            return Task.FromResult(custom);

        }

        [HttpGet("{id}")]
        public Task<Customer> Get(int id)
        {
            Customer custom = icustomer.GetCustomer(id);
            return Task.FromResult(custom);

        }

       

        [HttpPut]
        public Task<Customer> UpdateCustomer(Customer customer)
        {
           Customer custom = icustomer.Update(customer);
            return Task.FromResult(custom);
        }

        [HttpDelete]
        public Task<Customer> DeleteCusomer(int id)
        {
            Customer custom = icustomer.Delete(id);
            return Task.FromResult(custom);
        }

        
    }
}
