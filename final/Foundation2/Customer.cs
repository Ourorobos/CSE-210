using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
    public string GetShippingLabel()
    {
        return $"Name:\n{_name}\nAddress:\n{_address.GetAddress()}\n";
    }
}