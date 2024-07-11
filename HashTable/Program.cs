// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


/* 
 * Описание: Разработайте алгоритм, обнаруживающий в массиве все пары целых чисел, сумма которых равна заданному значению
 * 
 * Очень простое и эффективное (по времени) решение — создание хэш-таблицы, отображающей целое число в целое число. 
 * Данный алгоритм работает, пошагово проходя весь массив. Для каждого элемента x в хэш-таблице ищется sum – x и, 
 * если запись существует, выводится (x, sum — x). После этого x добавляется в таблицу и проверяется следующий элемент.
 */

//// суммирует только 2 числа в массиве
//TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();


// суммирует все пары целых чисел в массиве
//TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();

Print(TwoSum(new[] { 1, 2, 3, 2 }, 4));

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

            }

        }

    }

    return result.ToArray();

}
