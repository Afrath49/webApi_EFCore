namespace webApi_EFCore.Models
{
    public interface Icustomer
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAll();
        Customer Add(Customer customer);    
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
