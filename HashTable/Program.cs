// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


/* 
 * Описание: Разработайте алгоритм, обнаруживающий в массиве все пары целых чисел, сумма которых равна заданному значению
 * 
 * Очень простое и эффективное (по времени) решение — создание хэш-таблицы, отображающей целое число в целое число. 
 * Данный алгоритм работает, пошагово проходя весь массив.
 * Для каждого элемента x в хэш-таблице ищется sum – x и, если запись существует, выводится (x, sum — x).
 * После этого x добавляется в таблицу и проверяется следующий элемент.
 */

//// суммирует только 2 числа в массиве
//TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();


// суммирует все пары целых чисел в массиве
//TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();


int[] arr = { 1, 2, 3, 2, 5, 8, 3, 2,2, 4,0 };
Print(TwoSum(arr, 4)); // суммирует в пару число, по неск. раз
//Print(TwoSumHash(arr, 4)); // 1 и 2; 1 и 6

//arr.Where(x=>x+(x+1));

Console.ReadKey();

static void Print(IEnumerable<(int,int)> ints)
{
    foreach (var item in ints)
    {
        Console.WriteLine(item);
    }
}

static IEnumerable<(int,int)> TwoSum(int[] numbers, int target)
{

    var result = new HashSet<(int, int)>();

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int a = numbers[i] + numbers[j];
            if (a == target)
            {

                //new[] { numbers[i], numbers[j] };
                result.Add((numbers[i], numbers[j]));// при нахожд
            }

        }



    }


    return result;

   

}

//static int[] TwoSumHash(IEnumerable<int> numbers, int target)
//{
//    //HashSet<int> result = new HashSet<int>(numbers);


//    foreach (var item in numbers)
//    {
//        foreach (var item1 in result)
//        {
//            int a = item + item1;
//            if (a == target)
//            {
//                result.Add(item);
//                result.Add(item1);
//            }
//        }
//    }





//    return result.ToArray();

//}
