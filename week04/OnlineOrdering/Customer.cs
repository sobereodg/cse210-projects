class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInNigeria()
    {
        return address.IsInNigeria();
    }

    public string GetCustomerName()
    {
        return name;
    }

    public string GetCustomerAddress()
    {
        return address.GetFullAddress();
    }
}