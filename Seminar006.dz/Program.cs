// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


//   int[] FillArray(string[] args)
//   {
//     int size = int.Parse(Console.ReadLine());

//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)

//     {
//       Console.Write($"Введите {i +1} элемент массива: ");
//       array[i] = int.Parse(Console.ReadLine());
//     }
//     Console.WriteLine();

//     return array;
//   }

// void PrintArray(int[] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }

// int CountPositive(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//     {
//       count++;
//     }
//   }
//   return count;
// }

// Console.Write("Введите количество элементов массива: ");
// int[] array;
// array = FillArray(args);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositive(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Введите значение точки b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double[] element = SolutionEquation(b1, k1, b2, k2);
bool elements = Validate(b1, k1, b2, k2);
Console.Write($"Координаты точки пересечения -> ");
System.Console.WriteLine($"[{string.Join(", ", element)}]");


double[] SolutionEquation(double b1, double k1, double b2, double k2)
{
  double x = 0;
  double y1 = 0;
  double y2 = 0;
  double[] result = new double[2];
  for (int i = 0; i < result.Length; i++)
  {
    x = (b2 - b1) / (k1 - k2);
    y1 = k1 * x + b1;
    y2 = k2 * x + b2;
    y1 = Math.Round(y1, 1);
    y2 = Math.Round(y2, 1);
    result[0] = y1;
    result[1] = y2;


  }
  return result;
}

bool Validate(double b1, double k1, double b2, double k2)
{
  if (k1 == k2)
  {
    if (k1 == k2 || b1 == b2)
    {
      Console.WriteLine("Прямые совпадают");
      return false;
    }
    else
    {
      Console.WriteLine("Прямые паралельны");
      return false;
    }
  }
  return true;
}

