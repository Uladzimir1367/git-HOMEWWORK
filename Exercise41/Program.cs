/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();

int[] baseArray = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray)
{
   string[] nums = stringArray.Split();
   int[] res = new int[nums.Length];
   for (int i = 0; i < nums.Length; i++)
   {
      res[i] = int.Parse(nums[i]);
   }
   return res;
}
void GetSum(int[] arr)
{
   int Carrent = 0;
   
   for (int i = 0; i < arr.Length; i++)
   {
      if(arr[i] > 0)
      {
         Carrent ++;
      }

   }
   Console.WriteLine();
   Console.WriteLine($"Количество чисел больше 0 = {Carrent}");
}

int[] array = GetArrayFromString(elements);
GetSum(array);










