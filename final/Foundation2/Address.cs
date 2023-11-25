public class Address
{
    // attributes...
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // constructor to set street, city, state, and country...
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    // methods...

    // return true or false depending whether customer lives in the USA or not
    public string ReturnWhereLive()
    {
        return _country;
    }

    // display address
    public string DisplayAddress()
    {
        return $"{_street}\n{_city}\n{_stateProvince}, {_country}";
    }
}