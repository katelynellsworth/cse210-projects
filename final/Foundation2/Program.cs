using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encapsulation with Online Ordering");

        Address address1 = new Address("2558 mint lane", "AquaFresh", "Alabama", "USA");
        Customer customer1 = new Customer("Listerine Collgate", address1);

        List<Product> bathroomProducts = new List<Product>();
        Product bathroomProduct1 = new Product("Toothbrush", "64723", 3, 1.29);
        Product bathroomProduct2 = new Product("Toothpaste", "64821", 2, 2.67);
        Product bathroomProduct3 = new Product("Hand Soap", "45321", 1, 1.75);
        Product bathroomProduct4 = new Product("Towel", "11121", 2, 10.22);
        bathroomProducts.Add(bathroomProduct1);
        bathroomProducts.Add(bathroomProduct2);
        bathroomProducts.Add(bathroomProduct3);
        bathroomProducts.Add(bathroomProduct4);

        Order bathroomOrder = new Order(bathroomProducts, customer1);

        bathroomOrder.DisplayShippingLabel();
        Console.WriteLine("");
        bathroomOrder.DisplayPackingLabel();
        Console.WriteLine("");
        bathroomOrder.DisplaySumOfOrder();
        Console.WriteLine("");

        Address address2 = new Address("6474 Chicken drive", "Crockpot", "Onterio", "Canada");
        Customer customer2 = new Customer("Bell Bosch", address2);

        List<Product> kitchenProducts = new List<Product>();
        Product kitchenProduct1 = new Product("Strainer", "12543", 1, 4.55);
        Product kitchenProduct2 = new Product("Knife", "10923", 6, 7.62);
        Product kitchenProduct3 = new Product("Dish Soap", "45521", 2, 3.21);
        Product kitchenProduct4 = new Product("Towel", "11000", 6, 4.99);
        kitchenProducts.Add(kitchenProduct1);
        kitchenProducts.Add(kitchenProduct2);
        kitchenProducts.Add(kitchenProduct3);
        kitchenProducts.Add(kitchenProduct4);

        Order kitchenOrder = new Order(kitchenProducts, customer2);
        
        kitchenOrder.DisplayShippingLabel();
        Console.WriteLine("");
        kitchenOrder.DisplayPackingLabel();
        Console.WriteLine("");
        kitchenOrder.DisplaySumOfOrder();
        Console.WriteLine("");
    }
}