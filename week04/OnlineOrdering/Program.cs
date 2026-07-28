using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main St",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "P100", 30, 2));
        order1.AddProduct(new Product("Mouse", "P101", 20, 1));
        order1.AddProduct(new Product("Monitor", "P102", 150, 1));


        Address address2 = new Address(
            "Av. Libertador",
            "Caracas",
            "Distrito Capital",
            "Venezuela");

        Customer customer2 = new Customer("Maria Perez", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P200", 50, 1));
        order2.AddProduct(new Product("Webcam", "P201", 80, 1));


        Console.WriteLine("ORDER 1");
        Console.WriteLine("---------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");


        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine();


        Console.WriteLine("ORDER 2");
        Console.WriteLine("---------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}