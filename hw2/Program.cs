/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = rnd.Next(0,11);
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

//Найдите сумму элементов, стоящих на нечётных позициях.

int GetOddNumber(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int dimension = GetNumber ("Введите размер массива");
int[] array = InitArray(dimension);
PrintArray(array);
int summ = GetOddNumber(array);

Console.WriteLine (summ);