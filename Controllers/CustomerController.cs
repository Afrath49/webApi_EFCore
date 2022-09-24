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
        public Task<Customer> Add(Customer customer)
        {
            return Task.Run(()=>
            {
                Customer custom = icustomer.add(customer);
                return custom;
            });
        }


        [HttpGet] 
        public Task<IEnumerable<Customer>> GetAll()
        {
            return Task.Run(() =>
            {
                IEnumerable<Customer> custom = icustomer.getAll();
                return custom;
            });
        }


        [HttpGet("{id}")]
        public Task<Customer> Get(int id)
        {
            return Task.Run(() =>
            {
                Customer custom = icustomer.get(id);
                return custom;
            });
       }


       [HttpPut]
        public Task<Customer> Update(Customer customer)
        {
            return Task.Run(() =>
            {
                Customer custom = icustomer.update(customer);
                return custom;
            });
          
        }


        [HttpDelete]
        public  Task<Customer> Delete(int id)
        {
            return  Task.Run(() =>
            {
                Customer custom = icustomer.delete(id);
                return custom;
            });
        }

        
    }
}
