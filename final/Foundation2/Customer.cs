using System;

public class Customer
{
    private string _customerName;
    private Address _adress;


    // Constructor //
    public Customer(string name, Address address)
    {
        _customerName = name;
        _adress = address;
    }

    // USA Checker //
    public double ShippingFee()
    {
        double shippingFee = 0;

        if (_adress.GetCountry() == "USA")
        {
            shippingFee = 5;
        }

        else
        {
            shippingFee = 35;
        }

        return shippingFee;
    }

    // Get Customer //
    public void GetCustomer()
    {
        Console.WriteLine($"{_customerName}, {_adress.GetAddress()}");
    }
}