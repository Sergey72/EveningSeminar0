// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// ------------------------------------------------------------

// void PrintNumberToN(int N)
// {

//   if (N <= 0)
//   {
//     return;
//   }
//   else
//   {
// System.Console.Write(N + " ");
//   PrintNumberToN(N - 1);
//   }
// }



// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // System.Console.Write(PrintNumberToN(number));
// PrintNumberToN(number);
// --------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int PrintNumberFromMToN(int M, int N)
// {
//   if (N == M - 1)
//   {
//     return 0;
//   }
//   return N + PrintNumberFromMToN(M, N - 1);
// }


// System.Console.Write("Введите начальное число: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конечное число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(PrintNumberFromMToN(numberM, numberN));

// ---------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akkerman(int m, int n)
// {
//   if (m == 0)
//   {
//     return n + 1;
//   }
//   else
//   if (n == 0)
//   {
//     return Akkerman(m - 1, 1);
//   }
//   else
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// System.Console.WriteLine("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Функциия Аккермана {Akkerman(numberM, numberN)}");