public class Address
{
    private string LocationAddress { get; set; }
    private string City { get; set; }
    private string StateOrProvince { get; set; }
    private string Country { get; set; }

    // Constructor
    public Address(string locationAddress, string city, string stateOrProvince, string country)
    {
        LocationAddress = locationAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    // Check if the customer is located in the USA
    public bool LocationUSA()
    {
        return Country.ToLower() == "usa";
    }

    // Return full address as a formatted string
    public string FullAddress()
    {
        return $"{LocationAddress}\n{City}, {StateOrProvince}\n{Country}";
    }
}
