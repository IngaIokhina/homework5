/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// метод получения числа с консоли
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

//метод инициализации массива
int[] InitArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,100);
    }
    return array;
}

//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод поиска макс и мин

int GetMaxMin(int[] array)
{

int max = array[0];
int min = array[0];


for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}

return max - min;
}

int dimension = GetNumber ("Введите размер массива");
int[] array = InitArray(dimension);
PrintArray(array);

int sum = GetMaxMin(array);
Console.WriteLine ($"Difference between maximum and minimum value {sum}");