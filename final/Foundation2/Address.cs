public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool livingInUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public bool ReturnWhereLive()
    {
        if (_city == "USA")
        {
            livingInUSA = true;
        }
        else
        {
            livingInUSA = false;
        }

        return livingInUSA;
    }

    public string DisplayAddress()
    {
        return $"{_street} \n {_city} \n {_stateProvince}, {_country}";
    }
}