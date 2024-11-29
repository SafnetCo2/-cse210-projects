using System;

public class Customer
{
    private string _name { get; set; }
    private Address _address { get; set; }

    // Constructor to initialize the customer with name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if the customer's address is in the USA
    public bool LocationUSA()
    {
        return _address.LocationUSA();
    }

    // Get customer's name
    public string DisplayName()
    {
        return _name;
    }

    // Get customer's address
    public string DisplayAddress()
    {
        return _address.FullAddress();
    }
}
