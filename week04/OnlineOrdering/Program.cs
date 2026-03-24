using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address addr1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L101", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M202", 25.50, 2));


        Address addr2 = new Address("456 Sakura Rd", "Tokyo", "Tokyo", "Japan");
        Customer cust2 = new Customer("Hanako Sato", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone Case", "P303", 15.00, 3));
        order2.AddProduct(new Product("Screen Protector", "S404", 10.00, 2));
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotal():0.00}");
        Console.WriteLine("----------------------------------");
    }
}