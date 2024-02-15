using System;

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    // Constructor //
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Compute Price //
    public double GetPrice()
    {
        return _price * _quantity;
    }

    // Get Product Info //
    public void GetProduct()
    {
        Console.WriteLine($"({_name}) - id:{_id} / Total Price: $ {GetPrice()}");
    }
}