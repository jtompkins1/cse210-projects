using System;

class Program
{
    static void Main(string[] args)
    {
       Address a1 = new Address("123 Main St.", "Rogers", "AR", "USA");
       Address a2 = new Address("456 SCM Rd", "Calgary", "Alberta", "Canada");

       Customer c1 = new Customer("John Smith", a1);
       Customer c2 = new Customer("Dr. Person", a2);

       Product p1 = new Product("Pants", "123456", 19.99, 2);
       Product p2 = new Product("Shirt", "321654", 24.99, 3);
       Product p3 = new Product("Paper", "987654", 4.50, 1);
       Product p4 = new Product("Candy", "121212", 5.99, 4);

       Order order1 = new Order(c1);





    }
}