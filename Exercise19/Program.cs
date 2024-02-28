// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int n = Prompt("Введите число: ");

FindNumber(n);
void FindNumber(int N)
{
   if ((N >= 0) && (N <= 9999) || (N >= 100000))
      {
      Console.WriteLine("Это не пятизначное число ");
      }

      if ((N >= 10000) && (N <= 99999))
      {
         int a = N/10000 % 10;
         int b = N % 10;
         if (a == b)
            {
            int c = N/1000 % 10;
            int d = N/10 % 10;
            if (c == d)
               {
                  Console.WriteLine("Это число полиндром");
               } 
            }
      else
      {
         Console.WriteLine("Это число не полиндром");
      }
   }
}
int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine());
   int num = Convert.ToInt32(value);
   return num;  
}