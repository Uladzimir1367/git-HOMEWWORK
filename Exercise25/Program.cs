// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа");
int B = int.Parse(Console.ReadLine()!);

FindNumber(A);
void FindNumber(int A)
{
   int i = 1;
   int Pr = 1;
   for (i=1; i <= B; i++)  
   {
       
      Pr = Pr*A;
   }
   Console.WriteLine(Pr);

     
}


