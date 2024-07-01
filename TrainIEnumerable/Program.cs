// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");


var x = new[] { 7, 3, 15, 5 };


//IEnumerable<string> x = null;


foreach (var s in ConvertToFooBar(x))
{
    Console.WriteLine(s);
    // должен вывести
    // "foo"
    // "7" 
    // "foobar"
    // "bar"
}



static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
{


    var query = enumerable
        .Where(x => x % 3 == 0).Select(x => "foo")
        //.Where(x => x % 5 == 0).Select(x => "bar")
        .Where(x => x % 15 == 0).Select(x => "foobar")
        .Where(x => x % 3 != 0 && x=>x%5 != 0 $$ x => x % 15 != 0).Select(x => x.ToString());

    return query;

    //foreach (int a in enumerable)
    //{
    //    if (a % 15 == 0) yield return "foobar";
    //    if (a % 5 == 0) yield return "bar";
    //    if (a % 3 == 0) yield return "foo"; 
    //    else yield return a.ToString();
    //}
}


Console.ReadKey();


