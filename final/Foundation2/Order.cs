using System;

public class Order
{

    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int shipCost;

    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public int CalculateTotal()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            // int price =
            // total += 
        }
        return total;
    }
    public string GetPackingLabel(string prodName, string prodId)
    {
        string packLabel = ($"{prodName} - {prodId}");
        return packLabel;
    }
    public string GetShippingLabel(string custName, Address address)
    {
        string shipLabel = ($"{custName} \n{address}");
        return shipLabel;
    }
    public int GetShippingCost(bool usa)
    {
        if (usa == true)
        {
            shipCost = 5;
        }else
        {
            shipCost = 35;
        }
        return shipCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
}