namespace webApi_EFCore.Models
{
    public interface Icustomer
    {
        Customer get(int id);
        IEnumerable<Customer> getAll();
        Customer add(Customer customer);    
        Customer update(Customer customer);
        Customer delete(int id);
    }
}
