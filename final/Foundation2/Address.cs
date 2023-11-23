public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _livingInUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public bool ReturnWhereLive()
    {
        if (_country == "USA")
        {
            _livingInUSA = true;
        }
        else
        {
            _livingInUSA = false;
        }

        return _livingInUSA;
    }

    public string DisplayAddress()
    {
        return $"{_street}\n{_city}\n{_stateProvince}, {_country}";
    }
}