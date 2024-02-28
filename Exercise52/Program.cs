// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());

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


void AverigArray(int [,]array)
{
   float[] averages = new float[columns];
   for (int j = 0; j < columns; j++)
   {
      int sum = 0;
      for (int i = 0; i < rows; i++)
      {
      sum += array[i,j];
      }
      averages[j] = (float)sum / rows;
   }
   Console.WriteLine("Средние арифметические:");
   for (int j = 0; j < columns; j++)
   {
      Console.Write(averages[j] + "  ");
   }
   Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Получен массив: ");
int[,] array = GetArray(rows, columns, 0, 20);
AverigArray(array);










