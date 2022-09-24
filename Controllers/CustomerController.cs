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
        public async Task<Customer> Add(Customer customer)
        {
            return await Task.Run(()=>
            {
                Customer custom = icustomer.add(customer);
                return custom;
            });
        }


        [HttpGet] 
        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await Task.Run(() =>
            {
                IEnumerable<Customer> custom = icustomer.getAll();
                return custom;
            });
        }


        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await Task.Run(() =>
            {
                Customer custom = icustomer.get(id);
                return custom;
            });
       }


       [HttpPut]
        public async Task<Customer> Update(Customer customer)
        {
            return await Task.Run(() =>
            {
                Customer custom = icustomer.update(customer);
                return custom;
            });
          
        }


        [HttpDelete]
        public async Task<Customer> Delete(int id)
        {
            return await Task.Run(() =>
            {
                Customer custom = icustomer.delete(id);
                return custom;
            });
        }

        
    }
}
