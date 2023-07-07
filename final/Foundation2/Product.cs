using System;

public class Product
{
    private string _prodName;
    private string _id;
    private double _price;
    private double _qty;


    public Product(string prodName, string id, double price, double qty)
    {
        _prodName = prodName;
        _id = id;
        _price = price;
        _qty = qty;
    }
    public double CalculateQtyPrice()
    {
        return _price * _qty;
    }
    // public string GetName(string prodName)
    // {
    //     return _prodName;
    // }
    // public string GetId(string id)
    // {
    //     return _id;
    // }
    // public double GetQty(double qty)
    // {
    //     return _qty;
    // }
    // public double GetPrice(double price)
    // {
    //     return _price;
    // }
    
}