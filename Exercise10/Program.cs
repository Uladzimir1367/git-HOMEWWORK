// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rand = new Random().Next(100,1000);
Console.WriteLine("Рандомное число" + rand);

SekondNumber(rand);
void SekondNumber(int x)
{
int a = x / 10;
int b = a % 10;
rand = b;
}
Console.WriteLine("Найденное число" + rand);