// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Math.Abs(Prompt("Введите число N=  "));
NumCube(n);

int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine());
   int num = Convert.ToInt32(value);
   return num;  
}

void NumCube(int n)
{
   int Carrent = 1;
   int cube = 1;
   while (Carrent <= n)
      {
         cube = Math.Abs(Carrent*Carrent*Carrent);
         Carrent++;
         Console.WriteLine("Кубы чисел = " + cube);
      }
}