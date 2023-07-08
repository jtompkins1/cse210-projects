using System;

public class Order
{

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void DisplayTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateQtyPrice();
        }
        total += _customer.IsUSA() ? 5 : 35;
        total = Math.Round(total, 2);
        Console.WriteLine($"Total: ${total}");
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Product Label:");

        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()}({product.GetId()})");

        }

    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{_customer.GetCustomerName()}\n{_customer.GetAddress().GetCompleteAddress()}");

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
}