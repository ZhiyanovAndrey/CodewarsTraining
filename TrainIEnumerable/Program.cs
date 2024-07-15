// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");


var arr = new[] {3, 7, 15, 5 };


//IEnumerable<string> x = null;


foreach (var s in ConvertToFooBar(arr))
{
    Console.WriteLine(s);
    // должен вывести
    //3 - "foo"
    //7 - "7" 
    //15 - "foobar"
    //5 - "bar"
}



static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
{

    //var query = enumerable.Select(x =>
    //{
    //    if (x % 15 == 0) return "foobar";
    //    if (x % 5 == 0) return "bar";
    //    if (x % 3 == 0) return "foo";
    //    return x.ToString();
    //});

    //return query;

    foreach (int a in enumerable)
    {
        if (a % 15 == 0) yield return "foobar"; //
        else if (a % 5 == 0) yield return "bar";
        else if (a % 3 == 0) yield return "foo";
        else yield return a.ToString();
    }
}


Console.ReadKey();


