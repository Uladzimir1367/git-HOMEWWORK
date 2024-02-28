/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double Prompt(string message)
{
   Console.Write(message);
   string value = Console.ReadLine();
   double num = Convert.ToInt32(value);
   return num;  
}
double k1 = Prompt("Введите коэффициент к1: ");
double b1 = Prompt("Введите коэффициент b1: ");
double k2 = Prompt("Введите коэффициент k2: ");
double b2 = Prompt("Введите коэффициент b2: ");


double res = FindPount(k1, k2, b1, b2);

double FindPount(double k1, double k2, double b1, double b2)
{
   double x = Convert.ToDouble((b2-b1)/(k1-k2));
   double y = Convert.ToDouble(k2*x + b2);
   Console.WriteLine($"Точка пересечения прямых X,Y  {x} {y}");
   return y;
  
} 