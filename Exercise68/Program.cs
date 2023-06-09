// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Main();

void Main() // Ввод и вывод данных
{
   int n = Prompt("Введите число M  ");
   int m = Prompt("Введите число N  ");
   Console.WriteLine($"Result, S = {A(n, m)}");
}

int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine()!);
   return value;
}

int A(int n, int m) 
{
   if (n == 0)
   {
      return (m+1);
   }
   else if ((n != 0) && (m == 0))
   {
      return A(n - 1, 1);
   }
   else 
   {
      return A (n-1, A (n, m-1));
   }
}