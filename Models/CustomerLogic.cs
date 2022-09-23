namespace webApi_EFCore.Models
{
    public class CustomerLogic : Icustomer
    {
        private readonly CustomerdbContext context;
        public CustomerLogic(CustomerdbContext context)
        {
            this.context = context;
        }
        public Customer Add(Customer customer)
        {
            context.Customers.Add(customer);
             context.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
             Customer customer = context.Customers.Find(id);
             if(customer != null)
            {
                context.Customers.Remove(customer);
             context.SaveChanges();
            }
            return customer;

        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers;
        }

        public Customer GetCustomer (int id)
        {
            return context.Customers.Find(id);
       
        }

        public Customer Update(Customer customer)
        {
            var custom = context.Customers.Attach(customer);
            custom.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customer;
        }
      
    }
}
