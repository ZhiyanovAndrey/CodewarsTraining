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


int[] arr = { 1, 2, 3, 2, 5, 8, 3, 2 };
Print(TwoSum(arr, 5)); // суммирует в пару число, по неск. раз
//Print(TwoSumHash(arr, 4)); // 1 и 2; 1 и 6

arr.Where(x=>);

Console.ReadKey();

static void Print(IEnumerable<int> ints)
{
    foreach (var item in ints)
    {
        Console.WriteLine(item); 
    }
}

static int[] TwoSum(int[] numbers, int target)
{
    List<int> result = new List<int>();
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int a = numbers[i] + numbers[j];
            if (a == target)
            {
                result.Add(numbers[i]);
                result.Add(numbers[j]);
                break;  // при совпа
            }

        }

    }

    return result.ToArray();

}

static int[] TwoSumHash(IEnumerable<int> numbers, int target)
{
    HashSet<int> result = new HashSet<int>(numbers);


   

    

    return result.ToArray();

}
