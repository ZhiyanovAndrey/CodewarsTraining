// See https://aka.ms/new-console-template for more information
using Delegate;





Console.WriteLine("Нажми Y, что бы запустить генератор цен");
Console.WriteLine("Нажми N, что бы прервать генератор");

string go = Console.ReadLine();

if (go.ToUpper() == "Y") // как прервать поток
{

    Generator generator = new Generator();
    generator.PriceChangeHandler = Showprice; // регистрируем метод через свойство PriceChangeHandler

    void Showprice(int price) => Console.WriteLine($"Новая цена {price}");

    generator.Start();

    //while (true)
    //{

    Console.ReadLine();
    //}

}


