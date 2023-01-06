Описание решения:

 1. Функция для считывания массива:

                string[] ReadArray(string message)
                {
                    Console.WriteLine(message);
                    return Console.ReadLine().Split();
                }
 2. Основная функция. Удаляет из массива строки у которых длина больше 3-х:

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
  3. Функция для вывода массива:

                void PrintArray(string[] arr)
                {
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                    Console.WriteLine();
                }
   4. Считывание массива:

                string[] arr = ReadArray("Вводите массив в одной строке");

   5. Вывод на экран с выводом основной функции:

                PrintArray(RemoveBigStrings(arr, 3));

               



                 Инструкция для пользователя:

                - ввести строки через пробел;

                - программа выводит строки, которые имеют длину <= 3.