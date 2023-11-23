public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string DisplayAddress()
    {
        return $"{_street} \n {_city} \n {_stateProvince}, {_country}";
    }
}