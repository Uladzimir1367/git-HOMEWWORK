﻿// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
// Задать размер массива
int n = 4;

// Создать массив
int[,] array = new int[n,n];



// Заполнить массив спирально
int value = 1; // переменная для хранения текущего значения
int top = 0; // верхняя граница массива
int bottom = n - 1; // нижняя граница массива
int left = 0; // левая граница массива
int right = n - 1; // правая граница массива

while (true)
{
   // Заполнить верхнюю строку слева направо
   for (int i = left; i <= right; i++)
   {
      array[top, i] = value;
      value++;
   }
   top++; // сдвинуть верхнюю границу вниз

   // Проверить, не вышли ли за границы массива
   if (top > bottom || left > right) break;

   // Заполнить правый столбец сверху вниз
   for (int i = top; i <= bottom; i++)
   {
      array[i, right] = value;
      value++;
   }
   right--; // сдвинуть правую границу влево

   // Проверить, не вышли ли за границы массива
   if (top > bottom || left > right) break;

   // Заполнить нижнюю строку справа налево
   for (int i = right; i >= left; i--)
   {
      array[bottom, i] = value;
      value++;
   }
   bottom--; // сдвинуть нижнюю границу вверх

   // Проверить, не вышли ли за границы массива
   if (top > bottom || left > right) break;

   // Заполнить левый столбец снизу вверх
   for (int i = bottom; i >= top; i--)
   {
      array[i, left] = value;
      value++;
   }
   left++; // сдвинуть левую границу вправо

   // Проверить, не вышли ли за границы массива
   if (top > bottom || left > right) break;
}

// Вывести массив в консоль
Console.WriteLine("Спиральный массив 4 на 4:");
for (int i = 0; i < n; i++) // для каждой строки
{
   for (int j = 0; j < n; j++) // для каждого столбца
   {
      Console.Write(array[i, j] + " "); // вывести элемент массива с пробелом
   }
   Console.WriteLine(); // перейти на новую строку после каждой строки массива
}


