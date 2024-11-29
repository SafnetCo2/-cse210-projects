using System;

public class Product
{
    private string _name { get; set; }
    private int _productId { get; set; }
    private double _price { get; set; }
    private int _quantity { get; set; }

    // Constructor to initialize the product with details
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Get the total cost of the product (price * quantity)
    public double TotalOrderCost()
    {
        return _price * _quantity;
    }

    // Public getters for the name and product ID
    public string Name => _name;
    public int ProductId => _productId;
}
