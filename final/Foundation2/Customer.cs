public class Customer
{
    // attributes...
    private string _nameCustomer;
    private Address _addressCustomer;

    // constructor to set customer street, city, state, and country to address constructor...
    public Customer(string name, string street, string city, string state, string country)
    {
        _nameCustomer = name;

        _addressCustomer = new Address(street, city, state, country); // instance of Address class to call some methods
    }

    // methods...

    // get name
    public string GetNameCustomer()
    {
        return _nameCustomer;
    }

    // get true if customer lives in USA or false if he/she doesn't
    public bool GetLivingInUSA()
    {
        return _addressCustomer.ReturnWhereLive();
    }

    // get address from address class
    public string GetAddress()
    {
        return _addressCustomer.DisplayAddress();
    }
}