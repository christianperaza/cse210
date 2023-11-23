public class Customer
{
    private string _nameCustomer;
    private Address _addressCustomer;

    public Customer(string name, string street, string city, string state, string country)
    {
        _nameCustomer = name;
        _addressCustomer = new Address(street, city, state, country);
    }

    public string GetNameCustomer()
    {
        return _nameCustomer;
    }

    public bool GetLivingInUSA()
    {
        return _addressCustomer.ReturnWhereLive();
    }

    public string GetAddress()
    {
        return _addressCustomer.DisplayAddress();
    }
}