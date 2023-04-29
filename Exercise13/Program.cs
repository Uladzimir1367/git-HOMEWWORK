// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int ValueN = int.Parse(Console.ReadLine());

FindNumber(ValueN);
void FindNumber(int N)
{
   if ((N > 10000) && (N <= 100000))
   {
      int a = N/100;
      int b = a % 10;
      Console.WriteLine("Третья цифра числа" +b);
   }
   if ((N >= 1000) && (N <= 10000))
   {
      int a = N/10;
      int b = a % 10;
      Console.WriteLine("Третья цифра числа" +b);
   }   
   if ((N > 99) && (N < 1000)) 
   {
      int a = N % 10;
      Console.WriteLine("Третья цифра числа" +a);
   }

   else if(N < 100)
   {
      Console.WriteLine("Третьей цифры нет");
   } 
}

