// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = Prompt();
NaturalNum(N);
int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

void NaturalNum(int limit)
{
    if (limit == 1)
    {
        Console.Write(limit + " " );
    }
    else
    {
        Console.Write(limit + " ");
        NaturalNum(limit - 1);
    }
}