// Домашнее задание


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNumber(int num)
// {
//   num = num % 100;
//   int second = num / 10;
//   return second;
// }

// Console.Write("Input is Three-digit number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SecondNumber(number1));


int Prompt(string message)
{
  System.Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(value);
  return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
  Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
  return;
}
Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

/*
int Number(int num)
{
  int num1 = num % 1000;
  int des = num1 / 100;
  return des;
}

Console.Write("Введи любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99)
  Console.WriteLine("Третьей цифры в нем нет");
else
  Console.WriteLine(Number(number));
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool DayWeek(int day)
// {
//   int week1 = 6;
//   int week2 = 7;

//   if ((day == week1) || (day == week2))
//   {
//     return true;
//   }
//   else
//   {
//     return false; 
//   }
// }
// Console.Write("Введи цифру дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(DayWeek(number) == true)
// Console.WriteLine("Да, этот день выходной.");
// else
// Console.WriteLine("Нет, этот день не выходной.");