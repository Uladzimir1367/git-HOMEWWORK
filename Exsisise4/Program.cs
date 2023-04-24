// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a =   ");
Console.WriteLine("Введите число b =   ");
Console.WriteLine("Введите число c =   ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if ((a>b) && (a>c))
   {
   Console.WriteLine("Максимальное число =  "+a);
   }
      if ((b>a) && (b>c))
      {
      Console.WriteLine("Максимальное число =  "+b);  
      }
         if ((c>a) && (c>b))
         {
         Console.WriteLine("Максимальное число =  "+c); 
         }
