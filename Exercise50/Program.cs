// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет



Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс строки элемента массива: K ");
int K = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца элемента массива: N ");
int N = int.Parse(Console.ReadLine()!);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] result = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         result[i, j] = new Random().Next(minValue, maxValue);
         Console.Write($"{result[i, j]}  ");
      }
      Console.WriteLine();
   }
   return result;
}

void FindArray(int[,] array)
{
   // Проверяем индексы K и N - в пределах массива?
   if (K < 0 || K >= rows || N < 0 || N >= columns)
   {
      Console.WriteLine($"В массиве нет элемента с индексами [{K},{N}]");
      return;
   }

   // Ищем элемент с индексами K и N в массиве
   bool found = false;
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         if (i == K && j == N)
         {
            Console.WriteLine($"В массиве есть элемент c индексами [{K},{N}] его значение {array[i,j]}");
            found = true;
            break;
         }
      }
      if (found) break;
   }

   if (!found) // иначе сообщаем, что элемента нет
   {
      Console.WriteLine($"В массиве нет элемента с индексами [{K},{N}]");
   }
}


int[,] array = GetArray(rows, columns, 0, 100);
FindArray(array);

















