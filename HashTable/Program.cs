// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


/* 
 * Write a function that takes an array of numbers (integers for the tests) and a target number. 
 * It should find two different items in the array that, when added together, give the target value. 
 * The indices of these items should then be returned in a tuple / list (depending on your language) 
 * like so: (index1, index2). For the purposes of this kata, some tests may have multiple answers; 
 * any valid solutions will be accepted.
 * The input will always be valid (numbers will be an array of length 2 or greater, and all of the items 
 * will be numbers; target will always be the sum of two different items from that array).
 * 
 * 
 * 
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
//int[] arr = { 1, 2, 3, 2, 5, 8, 3, 2, 2, 4, 0, 6, 6, 6 };

int[] arr = { 9, 5, 5, 0 };
Print(TwoSum(arr, 4));
//Print(TwoSum(arr, 4)); // суммирует в пару число, по неск. раз
//Console.WriteLine();
//Print(TwoSumIndex(arr, 4)); // 1 и 2; 1 и 6

//arr.Where(x=>x+(x+1));

Console.ReadKey();


static void Print(IEnumerable<int> ints)
{
    foreach (var item in ints)
    {
        Console.WriteLine(item);
    }
}

//static void Print(IEnumerable<(int, int)> ints)
//{
//    foreach (var item in ints)
//    {
//        Console.WriteLine(item);
//    }
//}


static IEnumerable<int> TwoSumDictionary(int[] numbers, int target)
{
    //словарь для хранения уже просмотренных чисел
    System.Collections.Generic.Dictionary<int, int> dic = new Dictionary<int, int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        int delta = target - numbers[i];

        // если нет совпадений то возвращаем индекс num существует 
        if (dic.TryGetValue(delta, out int index))
        {
            var arr = new int[] { i, index };
            System.Array.Sort(arr);
            return arr;
        }
        else dic[numbers[i]] = i; // запись 1,0; 2.1; 

    }

    return new int[2];




    static int[] TwoSum(int[] numbers, int target)
    {

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int a = numbers[i] + numbers[j];
                if (a == target)
                {
                    return new[] { i, j };
                }

            }

        }
        return new int[2];
    }




   
}



