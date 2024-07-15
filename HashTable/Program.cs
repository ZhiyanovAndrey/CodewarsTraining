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


int[] arr = { 1, 2, 3, 2, 5, 8, 3, 2, 2, 4, 0 };
Print(TwoSum(arr, 4)); // суммирует в пару число, по неск. раз
Print(TwoSumIndex(arr, 4)); // 1 и 2; 1 и 6

//arr.Where(x=>x+(x+1));

Console.ReadKey();

static void Print(IEnumerable<(int, int)> ints)
{
    foreach (var item in ints)
    {
        Console.WriteLine(item);
    }
}

static IEnumerable<(int, int)> TwoSum(int[] numbers, int target)
{

    var result = new HashSet<(int, int)>(); // удаляет дубликаты, если 2 раза 2,2,2,2 то покажет только (2,2)

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int a = numbers[i] + numbers[j];
            if (a == target)
            {

                //new[] { numbers[i], numbers[j] };
                result.Add((numbers[i], numbers[j]));
            }

        }

    }


    return result;

}

static IEnumerable<(int, int)> TwoSumIndex(int[] numbers, int target)
{

    var result = new List<(int, int)>(); // удаляет дубликаты, если 2 раза 2,2,2,2 то покажет только (2,2)
    List<int> list = new List<int>(numbers);

    for (int i = 0; i < list.Count - 1; i++)
    {
        for (int j = i + 1; j < list.Count; j++)
        {
            int a = list[i] + list[j];
            if (a == target)
            {

                //new[] { numbers[i], numbers[j] };
                result.Add((numbers[i], numbers[j]));
                list.Remove(numbers[i]); 
                list.Remove(numbers[j]); 
            }

        }

    }





    //foreach (var item in list.Skip(^1))
    //{
    //    foreach (var item1 in list.Skip(1))
    //    {
    //        int a = item + item1;
    //        if (a == target)
    //        {
    //            result.Add((item, item1));
    //            //list.Remove(item); // удаление в процессе перебора масива дает исключение
    //            //list.Remove(item1);
    //        }
    //    }
    //}




    return result;

}





//    return result.ToArray();

//}
