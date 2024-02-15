using System;

public class Order
{
    private List<Product> _listOfProducts = new List<Product>();

    private Customer _customer;


    // Constructor //
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Add Product //
    public void AddProduct(Product product)
    {
        _listOfProducts.Add(product);
    }

    // Total Price //
    public double TotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _listOfProducts)
        {
            double price = product.GetPrice();
            totalPrice += price;
        }

        totalPrice = totalPrice += _customer.ShippingFee();

        return totalPrice;
    }

    // Show Total //
    public void GetTotalPrice()
    {
        Console.WriteLine($"Total: $ {TotalPrice()}");
    }

    // Show Shipping Fee //
    public void GetShowFee()
    {
        Console.WriteLine($"Total shipping fee: {_customer.ShippingFee()}");
    }

    // Packing Label //
    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label");
        
        foreach (Product product in _listOfProducts)
        {
            product.GetProduct();
        }
    }

    // Shipping Label //
    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping Label");

        Console.WriteLine("SHIPING TO: ");
        _customer.GetCustomer();
    }
}