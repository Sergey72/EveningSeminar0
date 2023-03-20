// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// void ReverseArray(int[] arr)
// {
//   int temp = 0;
//   for (int i = 0; i < arr.Length / 2; i++)
//   {
//     temp = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = temp;
//   }
// }

// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(size);
// System.Console.WriteLine($"[{string.Join(", ", arr)}]");
// ReverseArray(arr);
// System.Console.WriteLine($"[{string.Join(", ", arr)}]");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// System.Console.WriteLine("Введите длину стороны АБ: ");
// int sideAB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите длину стороны БС: ");
// int sideBC = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите длину стороны АС: ");
// int sideAC = Convert.ToInt32(Console.ReadLine());

// if (sideAB + sideBC > sideAC && sideAC + sideBC > sideAB && sideAB + sideAC > sideBC)
//   Console.WriteLine($"Треугольник со сторонами {sideAB}, {sideBC}, {sideAC} может быть");
// else
// {
//   Console.WriteLine($"Треугольника со сторонами {sideAB}, {sideBC}, {sideAC} не может быть");
// }


// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

//Вариант №1
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int end = 0;
// int d = 1;
// while (number > 0)
// {
//   end = end+number%2*d;
//   number /=2;
//   d *=10; 
// }
// Console.WriteLine(end);

// Вариант №2
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void PrintBinary(int number)
// {
//   if (number <= 0)
//   {
//     return;
//   }
//   PrintBinary(number / 2);
//   Console.Write(number % 2);
// }
// PrintBinary(number);


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int first = 0;
// int second = 1;
// int fib = 0;
// Console.Write("0 1 ");
// for (int i = 2; i < number; i++)
// {
//   fib = first + second;
//   first = second;
//   second = fib;
//   Console.Write($"{fib} ");
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] FillArray(int size)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(0, 11);
  }
  return array;
}

int[] CopyArray(int[] arr, int size)
{
  int[] arrayNew = new int[size];
  for(int i = 0; i < arrayNew.Length; i++)
  {
    arrayNew[i] = arr[i];
  }
 return arrayNew;
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(size);
int[] copy = CopyArray(arr, size);
System.Console.WriteLine($"[{string.Join(", ", arr)}]");
System.Console.WriteLine($"[{string.Join(", ", copy)}]");
