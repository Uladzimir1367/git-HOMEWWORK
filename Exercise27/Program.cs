// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);

FindNumber(A);
void FindNumber(int A)
{
   
   int b = 0;
   int sum = 0;
   while (A > 0)  
   {
      
      b = A % 10; 
      sum = sum + b;
      A = A / 10;
   }
   Console.WriteLine(sum);
}   