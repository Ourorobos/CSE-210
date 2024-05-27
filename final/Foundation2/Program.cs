using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("313 New Port Way", "Old Port", "New OldPort", "Old NewPort");
        Address add2 = new Address("123 TW Road", "Buffalo", "Wyoming", "USA");

        Customer cust1 = new Customer("Long John Silver", add1);
        Customer cust2 = new Customer("Mr.R", add2);

        Order order1 = new Order(cust1);
        Order order2 = new Order(cust2);

        order1.AddProduct(new Product("Lead Balls", 5674, 0.3, 100));
        order1.AddProduct(new Product("Powder", 2042, 0.75, 50));
        order1.AddProduct(new Product("Wood Wax", 675, 2.38, 1));
        order2.AddProduct(new Product("Packing Tape(12pc)", 332145, 60.99, 10));
        order2.AddProduct(new Product("2X4 (250pc)", 45234, 150.67, 5));

        Console.WriteLine("Order1: ");
        Console.WriteLine(order1.GetPackingList());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetBill());
        
        Console.WriteLine("Order2: ");
        Console.WriteLine(order2.GetPackingList());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetBill());
    }
}