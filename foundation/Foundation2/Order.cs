using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products { get; set; }
    private Customer _customer { get; set; }
    private const double _usaShippingCost = 5.00;
    private const double _internationalShippingCost = 35.00;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Add a product to an order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Compute the total cost of the order (product costs + shipping cost)
    public double TotalOrderCost()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalOrderCost();
        }

        double shippingCost = _customer.LocationUSA() ? _usaShippingCost : _internationalShippingCost;
        return totalProductCost + shippingCost;
    }

    // Generate packing label
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (Product ID: {product.ProductId})\n";
        }
        return label;
    }

    // Generate shipping label
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.DisplayName()}\n{_customer.DisplayAddress()}";
    }
}
