// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int rand = new Random().Next(1,11);
Console.WriteLine("Проверяемое число" + rand);

WeekDayNumber(rand);
void WeekDayNumber(int x)
{
   if ((x > 5) && (x <= 7))
   {
   Console.WriteLine("Ура - это выходной" + x);
   }
   if (x <= 5)
   {
   Console.WriteLine("Это рабочий день" + x);
   }
   else if (x > 7)
   {
   Console.WriteLine("Это не день недели" + x);
   }
}