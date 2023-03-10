// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ReadArray(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine().Split();
}

string[] RemoveBigStrings(string[] arr, int k)
{
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i].Length <= k)
        {
            res[j++] = arr[i];
        }
    }
    Array.Clear(res, j, res.Length - j);
    return res;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] arr = ReadArray("Вводите массив в одной строке");

PrintArray(RemoveBigStrings(arr, 3));