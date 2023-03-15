// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-9, 10);
// }
// return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);

// int sumPositive = 0;
// int sumNegative = 0;

// for(int i = 0; i < array.Length; i++)
// {
// if(array[i] > 0)
// {
// sumPositive+= array[i];
// }
// else
// {
// sumNegative+= array[i];
// }
// }

// System.Console.Write("Ваш случайный массив: ");
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// System.Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных значений равна {sumNegative}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(-10, 11);
//   }
//   return array;
// }

// int[] ChangeArray(int[] arr, int size)
// {
//   int[] CopyArr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     CopyArr[i] = arr[i];
//   }
//   for (int i = 0; i < CopyArr.Length; i++)
//   {
//     CopyArr[i] *= -1;
//   }
//   return CopyArr;
// }

// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(size);
// int[] changeArray = ChangeArray(arr, size);
// System.Console.WriteLine($"[{string.Join(", ", arr)}]");
// System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(0, 10);
//   }
//   return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(size);
// System.Console.WriteLine($"[{string.Join(", ", arr)}]");

// Console.WriteLine("Введите число для проверки: ");
// int checkNum = Convert.ToInt32(Console.ReadLine());

// bool isOk = false;
// for (int i = 0; i < arr.Length; i++)
// {
//   if (checkNum == arr[i])
//   {
//     isOk = true;
//     break;
//   }
// }
// if (isOk)
// {
//   Console.WriteLine($"Число {checkNum} есть в массиве.");
// }
// else
// {
//   Console.WriteLine($"Числа {checkNum} нет в массиве.");
// }

// Задача 35: Задайте одномерный массив из N случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(0, 100);
//   }
//   return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(size);
// System.Console.Write($"[{string.Join(", ", arr)}] -> ");

//  int count = 0;
// for(int i = 0; i < arr.Length; i++)
// {
//   if (arr[i] >= 10 && arr[i] <= 99)
//   {
//   count += 1;
//   }
// }

// Console.Write($"{count}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArray(int size)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-10, 11);
  }
  return array;
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", arr)}]");


int newLength = arr.Length / 2 + arr.Length % 2;
int[] newArr = new int[newLength];

for (int i = 0; i < arr.Length / 2; i++)
{
  newArr[i] = arr[i] * arr[arr.Length - 1 - i];
}
if (arr.Length % 2 > 0)
{
  newArr[newArr.Length - 1] = arr[arr.Length / 2];
}

System.Console.WriteLine($"[{string.Join(", ", newArr)}]");

// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(0, 10);
// }
// return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);

// int newLength = array.Length / 2 + array.Length % 2;
// int[] newArray = new int[newLength];
// for(int i = 0; i < array.Length / 2; i++)
// {
// newArray[i] = array[i] * array[array.Length - 1 - i];
// }
// if(array.Length % 2 > 0)
// {
// newArray[newArray.Length - 1] = array[array.Length / 2];
// }
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// System.Console.WriteLine($"[{string.Join(", ", newArray)}]");

