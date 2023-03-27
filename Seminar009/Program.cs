using static System.Console;


// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNumberToN(int N)
// {
// if(N == 0)
// {
//   return;
// }
// PrintNumberToN(N - 1);
// System.Console.Write($"{N} ");
// }


// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNumberToN(number);


// ------------------------------------------------------------

// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumberToN(int N)
// {
// if(N == 0)
// {
//   return;
// }
// PrintNumberToN(N - 1);
// System.Console.Write($"{N} ");
// }


// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNumberToN(number);


// -----------------------------------------------------------

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// void Numbers(int M, int N)
// {
//   if (M - 1 == N)
//   {
//      return;
//   }
//   Numbers(M, N - 1);
//   Console.Write($"{N} ");
// }
// Numbers(2,8);

// ---------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void PrintNumberFromMToN(int M, int N)


// {
//   if(N == M - 1)
//   {
//     return;
//   }
//   PrintNumberFromMToN(M, N - 1);
//   System.Console.Write($"{N} ");

// }


// System.Console.Write("Введите начальное число: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конечное число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// PrintNumberFromMToN(numberM, numberN);

// ------------------------------------------------------

// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumNumbersRec(int num)
// {

//   if (num == 0)
//   {
//     return 0;
//   }
//   return num % 10 + SumNumbersRec(num/10);
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SumNumbersRec(number));

// ----------------------------------------------------------

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exponentiation(int A, int B)
{
  if (B == 0)
  {
    return 1;
  }
  
return A * Exponentiation(A, B - 1);

}


System.Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень числа: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Exponentiation(numberA, numberB));
// Exponentiation(numberA, numberB);