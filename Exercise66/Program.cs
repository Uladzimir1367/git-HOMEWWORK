// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Main();

void Main() // Ввод и вывод данных
{
   int M = Prompt("Введите число M  ");
   int N = Prompt("Введите число N  ");
   Console.WriteLine($"Result, S = {sumNumbers(M, N)}");
}

int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine()!);
   return value;
}

int sumNumbers(int M, int N) // учтём все возможные варианты при расчёте суммы
{
   if (M == 0)
   {
      return (N * (N + 1)) / 2;
   }
   else if (N == 0)
   {
      return (M * (M + 1)) / 2;
   }
   else if (M == N)
   {
      return M;
   }
   else if (M < N)
   {
      return N + sumNumbers(M, N - 1);  // Если N > M
   }
   else return N + sumNumbers(M, N + 1); // Если M > N
}