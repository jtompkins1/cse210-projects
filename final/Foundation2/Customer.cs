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
    public string GetCustomerName()
    {
        return _custName;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}

