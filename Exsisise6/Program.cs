﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
if (A%2 == 0)
{
   Console.WriteLine("число чётное");
}
else
{
   Console.WriteLine("число нечётное");
}