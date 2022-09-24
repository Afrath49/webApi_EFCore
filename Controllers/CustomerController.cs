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
            return Task.Run(()=>
            {
                Customer custom = icustomer.Add(customer);
                return custom;
            });
        }


        [HttpGet]
        public Task<IEnumerable<Customer>> GetAllCustomer()
        {
            return Task.Run(() =>
            {
                IEnumerable<Customer> custom = icustomer.GetAll();
                return custom;
            });
        }


        [HttpGet("{id}")]
        public Task<Customer> Get(int id)
        {
            return Task.Run(() =>
            {
                Customer custom = icustomer.GetCustomer(id);
                return custom;
            });
       }


       [HttpPut]
        public Task<Customer> UpdateCustomer(Customer customer)
        {
            return Task.Run(() =>
            {
                Customer custom = icustomer.Update(customer);
                return custom;
            });
        }


        [HttpDelete]
        public Task<Customer> DeleteCusomer(int id)
        {
            return Task.Run(() =>
            {
                Customer custom = icustomer.Delete(id);
                return custom;
            });
        }

        
    }
}
