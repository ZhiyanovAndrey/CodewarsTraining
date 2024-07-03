// See https://aka.ms/new-console-template for more information
using Delegate;

Console.WriteLine("Hello, World!");

Generator generator = new Generator();
generator.PriceChangeHandler = Showprice;

void Showprice(int price)
{
    Console.WriteLine($"Новая цена {price}");
}

generator.Start();


