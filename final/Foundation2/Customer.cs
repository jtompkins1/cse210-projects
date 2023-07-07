using System;

public class Customer
{
    private string _custName;
    private Address _address;
    private bool _usa;

    public Customer(string custName, Address address, bool usa)
    {
        _custName = custName;
        _address = address;
        _usa = usa;
    }

    public bool IsUSA()
    {
        return true;
    }
}

