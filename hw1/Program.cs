/* Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
1. метод получения числа с консоли
2. метод инициалтизации массива
3. метод печати массива
4. метод нахождения чётных чисел

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
        array[i] = rnd.Next(100,1000);
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

// метод нахождения чётных чисел 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int GetEvenNumber(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        even++;
    }
    return even;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int evennum = GetEvenNumber(array);

Console.WriteLine(evennum);