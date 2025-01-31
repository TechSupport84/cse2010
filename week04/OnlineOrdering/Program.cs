using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Headphones", 102, 49.99m, 2);
        Product product3 = new Product("Keyboard", 103, 69.99m, 1);

 
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Vancouver", "BC", "Canada");


        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);


        Order order1 = new Order(customer1);
        order1.SetAddProduct(product1);
        order1.SetAddProduct(product2);

        Order order2 = new Order(customer2);
        order2.SetAddProduct(product3);


        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.GetTotalPrice():C}\n");
    
    }
}