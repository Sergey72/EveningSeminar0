// Задача №1 написать программу которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//   int hundreds = num / 100;
//   int ones = num % 10;

//   return hundreds * 10 + ones;
// }

// int randNumber = new Random().Next(100, 1000);

// int newNumber = CutNumber(randNumber);
// Console.WriteLine($"New version of {randNumber} is {newNumber}");

//Задача №2 Написать программу, которая принимает на вход некоторое число и проверяет 
// кратно ли это число одновременно а и б.

// bool multNumber(int number, int firstMultiple, int secondMultiple)

// {
//   return number % firstMultiple == 0 && number % secondMultiple == 0;

//   // if(number % firstMultiple == 0 && number % secondMultiple == 0)

//   //   return true;
//   // else
//   //   return false;

// }

// Console.Write("Input a number for checking: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a first Multiple: ");
// int mult1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second Multiple: ");
// int mult2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(multNumber(num, mult1, mult2));


// Задача №3 Написать программу, которая выводит случайное число 
// из отрезка от 10 до 99 и показывает наибольшую цифру этого числа.


// int HighestFigure(int num)
// {
//   int firstHig = num / 10;
//   int secondHig = num % 10;
//   int hig = 0;

//   if (firstHig > secondHig)
//     hig = firstHig;
//   else
//     hig = secondHig;
//   return hig;

// }

// int randNumber = new Random().Next(10, 100);

// int highest = HighestFigure(randNumber);
// Console.WriteLine($"Рандомное число {randNumber}");
// Console.WriteLine($"Наибольшая цифра {highest}");


// Задача №4 Напишите программу, которая принимает на  вход два числа и проверяет, 
// является ли одно число квадратом другого.


bool SquareNumber(int number1, int number2)
{
  if(number1 == number2 * number2 || number2 == number1 * number1)
  {
    return true;
  }
    
    else
    {
      return false;
    } 
}

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareNumber(number1, number2));


