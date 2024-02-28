// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Задать двухмерный прямоугольный массив размерностью m на n
int m = 3; // количество строк
int n = 4; // количество столбцов
           

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
   int[,] result = new int[n, m];
   for (int i = 0; i < n; i++)
   {
      for (int j = 0; j < m; j++)
      {
         result[i, j] = new Random().Next(minValue, maxValue);
         Console.Write($"{result[i, j]}  ");
      }
      Console.WriteLine();
   }
   return result;
}

void SumArray(int[,] array)
{
   int[] rowSums = new int[m]; // создать массив для хранения сумм строк
   for (int i = 0; i < m; i++)
   {
      int sum = 0; // переменная для хранения суммы текущей строки
      for (int j = 0; j < n; j++)
      {
         sum += array[i, j]; // прибавить элемент массива к сумме
      }
      rowSums[i] = sum; // сохранить сумму в массиве
   }

   // Определить минимальную сумму


   int minSum = rowSums[0]; // переменная для хранения минимальной суммы, изначально равна сумме первой строки
   for (int i = 1; i < m; i++)
   {
      if (rowSums[i] < minSum) // если сумма текущей строки меньше минимальной суммы
      {
         minSum = rowSums[i]; // обновить минимальную сумму
      }
   }
   Console.WriteLine("Суммы строк:");
   for (int i = 0; i < m; i++)
   {
      Console.WriteLine("Сумма строки {0} = {1}", i + 1, rowSums[i]); // вывести номер и сумму строки
   }

   Console.WriteLine("Минимальная сумма = {0}", minSum); // вывести минимальную сумму
}
Console.WriteLine();
Console.WriteLine("Получен массив: ");
int[,] array = GetArray(m, n, 0, 20);
SumArray(array);





