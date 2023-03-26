using static System.Console;

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// double[,] MatrixRandomNumber(int row, int column)
// {
//   double[,] array = new double[row, column];
//   Random rnd = new Random();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = rnd.NextDouble() * 10;
//       array[i, j] = (Math.Round(array[i, j], 1));
//     }
//   }
//   return array;
// }

// void PrintMatrix(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} \t");
//     }
//     Console.WriteLine("\n");
//   }
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Вариант №1 По позиции элемента.

// int[,] MatrixRandomNumber(int row, int column)
// {
//   int[,] array = new int[row, column];
//   Random rnd = new Random();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = rnd.Next(0, 10);
//     }
//   }
//   return array;
// }

// void PrintMatrix(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} \t");
//     }
//     Console.WriteLine("\n");
//   }


// }

// int PositionElementArray(int[,] array, int numRow, int numColumn)
// {
//   int elementValue = -1;
//   if (numRow >= array.GetLength(0) || numColumn >= array.GetLength(1))
//   {
//     Console.WriteLine("Такого числа в массиве нет.");
//     return -1;
//   }
//   else
//   {
//     elementValue = array[numRow, numColumn]; 
//     Console.WriteLine($"{elementValue} \t");

//   }
//   return elementValue;


// }


// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] matrix = MatrixRandomNumber(row, column);
// Console.Write("Введите 1 значение позиции элемента. ");
// int numRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2 значение позиции элемента. ");
// int numColumn = Convert.ToInt32(Console.ReadLine());
// PrintMatrix(matrix);
// PositionElementArray(matrix, numRow, numColumn);

// Вариант №2 По значению элемента.

// int[,] MatrixRandomNumber(int row, int column)
// {
//   int[,] array = new int[row, column];
//   Random rnd = new Random();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = rnd.Next(0, 30);
//     }
//   }
//   return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} \t");
//     }
//     Console.WriteLine("\n");
//   }


// }

// int PositionElementArray(int[,] array, int numberFromArray)
// {
// int numRow = 0;
// int numColumn = 0;
// int [,] arr = new int [numRow,numColumn];
// arr = array;
// int elementValue = arr[numRow, numColumn];
// // int verificationТumber = elementValue;
// if (numberFromArray != elementValue)
// {
//   Console.WriteLine("Такого числа в массиве нет.");
// }
// else 
// {
// Console.WriteLine($"{elementValue} \t");
// }
// return elementValue;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] matrix = MatrixRandomNumber(row, column);
// Console.Write("Введите число для проверки. ");
// int numberFromArray = Convert.ToInt32(Console.ReadLine());
// PrintMatrix(matrix);
// PositionElementArray(matrix, numberFromArray);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] MatrixRandomNumber(int row, int column)
{
  int[,] array = new int[row, column];
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(0, 10);
    }
  }
  return array;
}

void PrintMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

double[] SumElementColumn(int[,] array)
{
  double sum = 0;
  double[] arrSum = new double[array.GetLength(1)];

  for (int j = 0; j < array.GetLength(1); j++)
  {
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      sum = sum + array[i, j];
    }
    arrSum[j] = sum/array.GetLength(0);
    arrSum[j] = (Math.Round(arrSum[j], 1));
  }
  return arrSum;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = MatrixRandomNumber(row, column);
PrintMatrix(matrix);
double[] sumColumn = SumElementColumn(matrix);
System.Console.WriteLine($"Среднее арифметическое каждого столбца {string.Join(";  ", sumColumn)}");