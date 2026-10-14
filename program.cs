using System;
class Product
{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(1, "Keyboard", 350.00),
            new Product(2, "Mouse", 180.00),
            new Product(3, "Monitor", 2200.00)
        };

        Product mostExpensive = products[0];

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine(products[i].Name + " - $" + products[i].Price.ToString("F2"));

            if (products[i].Price > mostExpensive.Price)
            {
                mostExpensive = products[i];
            }
        }

        Console.WriteLine("Most expensive: " + mostExpensive.Name);
    }
}
