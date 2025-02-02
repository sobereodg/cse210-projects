using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address nigeriaAddress = new Address("Plot 7 Samuel Street Akpajo", "Eleme", "Rivers State", "Nigeria");
        Customer customer1 = new Customer("Goodluck Sobere", nigeriaAddress);

        Address ukAddress = new Address("10 Downing St", "London", "England", "UK");
        Customer customer2 = new Customer("Manasseh Etete", ukAddress);

        Product product1 = new Product("Laptop", "P001", 500000, 1);
        Product product2 = new Product("Wireless Mouse", "P002", 15000, 2);
        Product product3 = new Product("Keyboard", "P003", 30000, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ₦{order1.GetTotalPrice()}");

        Console.WriteLine("\n=== Order 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ₦{order2.GetTotalPrice()}");
    }
}
