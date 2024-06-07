using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 2: Encapsulation with Online Ordering");
        /* Once you have created these classes, write a program 
        that creates at least two orders with a 2-3 products each. 
        Call the methods to get the packing label, the shipping 
        label, and the total price of the order, and display the 
        results of these methods.*/

        // Order 1
        string order1CustName = "Jane Jones";
        string order1Street = "123 Winding Rd";
        string order1City = "Provo";
        string order1State = "UT";
        string order1Country = "USA";
        Address order1Address = new Address(order1Street, order1City, order1State, order1Country);
        Customer order1Cust = new Customer(order1CustName, order1Address);
        Product prod1_1 = new Product("Basil", 563, 3.99, 3);
        Product prod1_2 = new Product("Rosemary", 423, 6.99, 1);
        Product prod1_3 = new Product("Blueberry Bush", 1084, 45.99, 2);

        Order orderSet1 = new Order(order1Cust);
        orderSet1.AddProduct(prod1_1);
        orderSet1.AddProduct(prod1_2);
        orderSet1.AddProduct(prod1_3);

        Console.WriteLine("Packing Label");
        Console.WriteLine("-------------");
        orderSet1.GetPackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label");
        Console.WriteLine("--------------");
        orderSet1.GetShippingLabel();
        Console.WriteLine();
        Console.WriteLine("Total Cost With Shipping");
        Console.WriteLine("------------------------");
        Console.WriteLine(orderSet1.TotalCost());
        Console.WriteLine();



        // Order 2
        string order2CustName = "Michael Torrie";
        string order2Street = "67 Flat Rd";
        string order2City = "Lethbridge";
        string order2State = "Alberta";
        string order2Country = "Canada";
        Address order2Address = new Address(order2Street, order2City, order2State, order2Country);
        Customer order2Cust = new Customer(order2CustName, order2Address);
        Product prod2_1 = new Product("Canola Seed", 138, 29.99, 10);
        Product prod2_2 = new Product("Red Winter Wheat", 283, 10.99, 1);
        Product prod2_3 = new Product("Orchard Bees", 785, 99.99, 1);

        Order orderSet2 = new Order(order1Cust);
        orderSet2.AddProduct(prod2_1);
        orderSet2.AddProduct(prod2_2);
        orderSet2.AddProduct(prod2_3);

        Console.WriteLine("Packing Label");
        Console.WriteLine("-------------");
        orderSet2.GetPackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label");
        Console.WriteLine("--------------");
        orderSet2.GetShippingLabel();
        Console.WriteLine();
        Console.WriteLine("Total Cost With Shipping");
        Console.WriteLine("------------------------");
        Console.WriteLine(orderSet2.TotalCost());




    }
}