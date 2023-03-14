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

System.Console.WriteLine("Введите длину стороны АБ: ");
int sideAB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длину стороны БС: ");
int sideBC = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длину стороны АС: ");
int sideAC = Convert.ToInt32(Console.ReadLine());

if (sideAB + sideBC > sideAC && sideAC + sideBC > sideAB && sideAB + sideAC > sideBC)
  Console.WriteLine($"Треугольник со сторонами {sideAB}, {sideBC}, {sideAC} может быть");
else
{
  Console.WriteLine($"Треугольника со сторонами {sideAB}, {sideBC}, {sideAC} не может быть");
}


// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
