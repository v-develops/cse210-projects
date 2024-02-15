using System;

class Program
{
    static void Main(string[] args)
    {
        // Order Number 1 //
        Console.WriteLine("----------------------------------------------------------------------------");

        Address address1 = new Address("Rua Gabriel Freitas 120", "Salto", "São Paulo", "Brasil");

        Customer customer1 = new Customer("Joana Pereira Santos", address1);

        Product customer1Product1 = new Product("Apple Slicer", "9623", 2.99, 3);
        Product customer1Product2 = new Product("White plastic flower jar", "192", 0.50, 2);
        Product customer1Product3 = new Product("Leaf SmartPhone case", "7222", 6.20, 1);


        Order order1 = new Order(customer1);

        order1.AddProduct(customer1Product1);
        order1.AddProduct(customer1Product2);
        order1.AddProduct(customer1Product3);

        double order1ShippingFee = customer1.ShippingFee();

        double order1Total = order1.TotalPrice();

        // Display Order //
        order1.GetShippingLabel();
        Console.WriteLine("");

        order1.GetPackingLabel();
        Console.WriteLine("");

        order1.GetShowFee();
        Console.WriteLine("");

        order1.GetTotalPrice();


        // Order Number 2 //
        Console.WriteLine("----------------------------------------------------------------------------");

        Address address2 = new Address("2839 Watson Lane", "Charlotte", "North Carolina", "USA");

        Customer customer2 = new Customer("Jørgen Kristiansen", address2);

        Product customer2Product1 = new Product("Hand made Kitchen Knifes", "1001", 120.99, 1);
        Product customer2Product2 = new Product("Tênis ball", "13", 1.50, 12);

        Order order2 = new Order(customer2);

        order2.AddProduct(customer2Product1);
        order2.AddProduct(customer2Product2);

        double order2ShippingFee = customer2.ShippingFee();

        double order2Total = order2.TotalPrice();

        // Display Order //
        order2.GetShippingLabel();
        Console.WriteLine("");

        order2.GetPackingLabel();
        Console.WriteLine("");

        order2.GetShowFee();
        Console.WriteLine("");

        order2.GetTotalPrice();
        Console.WriteLine("----------------------------------------------------------------------------");
    }

}