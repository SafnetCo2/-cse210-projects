using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address instances
        Address address1 = new Address("12345 Elm st", "Houston", "TX", "USA");
        Address address2 = new Address("12345 Maple Av", "Toronto", "ON", "Canada");

        // Create customer instances
        Customer customer1 = new Customer("Mapy Jim", address1);
        Customer customer2 = new Customer("Sisy Paul", address2);

        // Create product instances
        Product product1 = new Product("Brake Pads", 101, 20.99, 2);
        Product product2 = new Product("Gear Box", 102, 20.99, 1);

        // Create order instances
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Display order details
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${Math.Round(order1.TotalOrderCost(), 2)}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${Math.Round(order2.TotalOrderCost(), 2)}\n"); 
    }
}
