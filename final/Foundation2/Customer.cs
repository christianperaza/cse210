public class Customer
{
    private string _nameCustomer;
    private Address _addressCustomer;

    public Customer(string name)
    {
        _nameCustomer = name;
    }

    public string GetNameCustomer()
    {
        return _nameCustomer;
    }
}