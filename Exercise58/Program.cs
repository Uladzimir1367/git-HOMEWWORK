// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
//Результирующая матрица будет:
// 18 20
// 15 18




// Задать две матрицы А1 и А2
int[,] A1 = GetArray(2, 2, 0, 20); // матрица 2x2

int[,] A2 = GetArray(2, 2, 0, 20); // матрица 2x2
Console.WriteLine();
int[,] result = MatrixMult(A1, A2);

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

int[,] MatrixMult(int[,] A1, int[,] A2)
{
   // Создать матрицу для хранения результата
   int[,] result = new int[A1.GetLength(0), A2.GetLength(1)]; // матрица 2x2

   // Выполнить перемножение матриц по формуле
   for (int i = 0; i < result.GetLength(0); i++) // для каждой строки результата
   {
      for (int j = 0; j < result.GetLength(1); j++) // для каждого столбца результата
      {
         int sum = 0; // переменная для хранения суммы произведений элементов
         for (int k = 0; k < A1.GetLength(1); k++) // для каждого элемента в строке А1 и столбце А2
         {
            sum += A1[i, k] * A2[k, j]; // прибавить произведение элементов к сумме
         }
         result[i, j] = sum; // сохранить сумму в результате
      }
   }

   // Вывести результат в консоль
   Console.WriteLine("Результат перемножения матриц:");
   for (int i = 0; i < result.GetLength(0); i++) // для каждой строки результата
   {
      for (int j = 0; j < result.GetLength(1); j++) // для каждого столбца результата
      {
         Console.Write(result[i, j] + " "); // вывести элемент результата с пробелом
      }
      Console.WriteLine(); // перейти на новую строку после каждой строки результата
   }
   return result;
}



