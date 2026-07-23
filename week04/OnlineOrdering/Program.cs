using System;
class Program
{
    static void Main(string[] args)
    {
        // ----------------------------------------------------
        // Order 1: Domestic Customer (USA)
        // ----------------------------------------------------
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.50, 1));
        order1.AddProduct(new Product("Desk Pad", "P103", 15.00, 1));

        // ----------------------------------------------------
        // Order 2: International Customer (Canada)
        // ----------------------------------------------------
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "P201", 45.00, 1));
        order2.AddProduct(new Product("27-inch Monitor", "P202", 299.99, 2));

        // ----------------------------------------------------
        // Display Results
        // ----------------------------------------------------
        DisplayOrderDetails(order1, 1);
        Console.WriteLine("\n" + new string('=', 40) + "\n");
        DisplayOrderDetails(order2, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNum)
    {
        Console.WriteLine($"=== ORDER #{orderNum} ===");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
    }
}