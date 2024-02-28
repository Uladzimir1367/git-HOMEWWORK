﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]

// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

int[] RandArr(int num)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(0, 101);
   }
   return array;
}
void PrintArr(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($" [{array[i]}]");
   }
   Console.WriteLine();
}
const int lengthArr = 8;

int[] arr = RandArr(lengthArr);
PrintArr(arr);
