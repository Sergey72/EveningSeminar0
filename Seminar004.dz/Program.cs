// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int NaturaleDegree(int num, int deg)
// {
//   int degree = 1;
//     for (int i = 1; i <= deg; i++)
//   {
//     degree *= num;

//   }
//   return degree;
// }
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите степень: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int deg = NaturaleDegree(number, number2);
// System.Console.WriteLine($"{number2} степень числа {number} = {deg}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int Sum(int num)
// {
//   int sum = 0;
//   int i = 1;
//   while (num != 0)
//   {
//     i = num % 10;
//     sum += i;
//     num /= 10;
//   }
//   return sum;
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(number);
// System.Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Вариант №1 Введение элементов массива вручную.

// int[] arrayRandom(int sample1, int sample2, int sample3, int sample4, int sample5, int sample6, int sample7, int sample8)
// {
//   int[] arr = { sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8 };

//   return arr;
// }

// System.Console.WriteLine("Введите элемент массива: ");
// int sample1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второй элемент: ");
// int sample2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третий элемент: ");
// int sample3 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите четвертый элемент: ");
// int sample4 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите пятый элемент: ");
// int sample5 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите шестой элемент: ");
// int sample6 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите седьмой элемент: ");
// int sample7 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите восьмой элемент: ");
// int sample8 = Convert.ToInt32(Console.ReadLine());
// int[] array = arrayRandom(sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8);
// System.Console.WriteLine($"[{string.Join(", ", array)}]"); //метод для вывода массива на экран.

// Вариант №2 Заполнение массива случайными числами.

// int[] arrayRandom(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(0, 100);
// }
// return arr;
// }

// System.Console.WriteLine("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = arrayRandom(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

