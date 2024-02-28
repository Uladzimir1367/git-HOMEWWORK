// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Prompt("Введите координату xa: ");
int y1 = Prompt("Введите координату ya: ");
int x2 = Prompt("Введите координату xb: ");
int y2 = Prompt("Введите координату уb: ");
int z1 = Prompt("Введите координату za: ");
int z2 = Prompt("Введите координату zb: ");

double d = FindLents(x1, x2, y1, y2, z1, z2);
double FindLents(int xa, int xb, int ya, int yb, int za, int zb)
{
   double result = Convert.ToDouble(Math.Round(Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya)+(zb-za)*(zb-za))),3));
   Console.WriteLine(result);
   return result;
} 

int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine());
   int coord = Convert.ToInt32(value);
   return coord;  
}