using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St.", "Rogers", "AR", "USA");
        Address a2 = new Address("456 SCM Rd", "Calgary", "Alberta", "Canada");

        Customer c1 = new Customer("John Smith", a1);
        Customer c2 = new Customer("Pepper Potts", a2);

        Product p1 = new Product("Pants", "123456", 19.99, 2);
        Product p2 = new Product("Shirt", "321654", 24.99, 3);
        Product p3 = new Product("Paper", "987654", 4.50, 1);
        Product p4 = new Product("Candy", "121212", 5.99, 4);

        Order order1 = new Order(c1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(c2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Console.WriteLine("ORDER #1");
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayTotal();
        Console.WriteLine();

        Console.WriteLine("ORDER #2");
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayTotal();
        Console.WriteLine();

    }
}