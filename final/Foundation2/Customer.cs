using System;

public class Customer
{
    private string _custName;
    private Address _address;

    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }
    public string GetName(string name)
    {
        return _custName;
    }
    public Address GetAddress(string address)
    {
        return _address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}

