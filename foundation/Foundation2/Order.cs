using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }
    private const double USA_ShippingCost = 5.00;
    private const double International_ShippingCost = 35.00;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    // Add a product to an order
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Compute the total cost of the order (product costs + shipping cost)
    public double TotalOrderCost()
    {
        double totalProductCost = 0;
        foreach (var product in Products)
        {
            totalProductCost += product.TotalOrderCost();
            
        }

        double shippingCost = Customer.LocationUSA() ? USA_ShippingCost : International_ShippingCost;
        return totalProductCost + shippingCost;
    }

    // packing label
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (Product ID: {product.ProductId})\n";
        }
        return label;
    }

    //  shipping label
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{Customer.DisplayName()}\n{Customer.DisplayAddress()}";
    }
}
