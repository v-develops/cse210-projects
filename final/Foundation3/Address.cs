using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    // Constructor //
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Get address //
    public string GetAddress()
    {
        return $"{_street} / {_city} / {_state} - {_country}";
    }
}