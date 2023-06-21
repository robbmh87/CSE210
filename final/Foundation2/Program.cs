using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Product 1", "P1", 10.0, 2);
        Product product2 = new Product("Product 2", "P2", 5.0, 3);

    
        Address address1 = new Address("123 Street St", "Fresno", "CA", "USA");
        Customer customer1 = new Customer("Robb Hoffman", address1);

        Address address2 = new Address("987 Happy Valley", "Phoenix", "AZ", "USA");
        Customer customer2 = new Customer("Mark Anderson", address2);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.GetTotalPrice());

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.GetTotalPrice());
    }
}



