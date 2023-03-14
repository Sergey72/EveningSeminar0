// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(100, 1000);
//   }
//   return array;
// }

// System.Console.WriteLine("Введите размер массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(number);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");


// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
//   if (array[i] %2 == 0)
//   {
//   count += 1;
//   }
// }

// Console.Write($"Количество четных элементов в массиве: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(-10, 10);
//   }
//   return array;
// }

// System.Console.WriteLine("Введите размер массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(number);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");


// int sum = 0;
// for(int i = 0; i < array.Length; i++)
// {
//   if (i %2 != 0)
//   {
//   sum += array[i];
//   }
// }

// Console.Write($"Сумма элементов в нечетных позициях в массиве: {sum}");


// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1


double[] FillArray(int size)
{
  double[] array = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.NextDouble() * 10;
    array[i] = (Math.Round(array[i], 1));
  }
  return array;
}

System.Console.WriteLine("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(number);
System.Console.Write($"[{string.Join("; ", array)}] -> ");



int i = 0;
double max = 0;
double dif = 0;

double min = array[i];
while (i < number)
{
  if (max < array[i])
  {
    max = array[i];
  }
  else
if (min > array[i])
  {
    min = array[i];
  }
  i++;
}
dif = max - min;
dif = (Math.Round(dif, 1));

Console.WriteLine(dif);