public class Customer
{
    private string Name { get; set; }
    private Address Address { get; set; }

    // Constructor
    public Customer(string name, Address address)
    {
        Name = name; // Correct assignment
        Address = address;
    }

    // Check if the customer is located in the USA
    public bool LocationUSA()
    {
        return Address.LocationUSA();
    }

    // Get customer's name
    public string DisplayName()
    {
        return Name;
    }

    // Return customer's address
    public string DisplayAddress()
    {
        return Address.FullAddress();
    }
}
