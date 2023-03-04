﻿// Задача №17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причем 
// X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.Write("Точка лежит в первой четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.Write("Точка лежит во второй четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.Write("Точка лежит в третьей четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.Write("Точка лежит в четвертой четверти");
// }
// else
// {
//     Console.Write("Точка лежит на оси");
// }


// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой 
// четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.Write("x = 0, + n; y = 0, + n");
// }
// else if (number == 2)
// {
//     Console.Write("x = 0, - n; y = 0, + n");
// }
// else if (number == 3)
// {
//     Console.Write("x = 0, - n; y = 0, - n");
// }
// else if (number == 4)
// {
//     Console.Write("x = 0, + n; y = 0, - n");
// }
// else
// {
//     Console.Write("Такой четверти нет.");
// }
  
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
string[] quarters = {"x > 0; y > 0", 
                    "x < 0; y > 0",
                    "x < 0; y < 0",
                    "x > 0; y < 0"};

System.Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

if(quater >= 1 && quater <= 4)
{
    System.Console.WriteLine(quarters[quater - 1]);
}
else
{
    System.Console.WriteLine("Неправильно номер четверти");
}



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// double FindLengh (double x1,double x2,double y1,double y2)
// {
//   double result = Math.Sqrt(Math.Pow(x2 - x1,2)+ Math.Pow(y2 - y1,2));
//   return result; 
// }

// Console.WriteLine("введите координату по оси Х первой точки");
// double x1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координату по оси y первой точки");
// double y1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координату по оси x второй точки");
// double x2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координату по оси y второй точки");
// double y2=Convert.ToInt32(Console.ReadLine());

//  double FindLengh2d=FindLengh(x1, x2, y1, y2);
// System.Console.WriteLine ($"расстояние между точками = {FindLengh2d}");



// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



// double number = 5;

// double res = Math.Pow(number, 2); // возведение в степень
// System.Console.WriteLine(res);

// double res = Math.Sqrt(number); // извлечение квадратного корня
// res = Math.Round(res, 3); // округление
// System.Console.WriteLine(res);



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4