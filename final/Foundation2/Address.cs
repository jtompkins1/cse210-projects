using System;

public class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddress()
    {
        string address = ($"{_street} \n{_city}, {_state}, {_zipCode} \n{_country}");
        return address;
    }
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }else
        {
            return false;
        }
    }
}