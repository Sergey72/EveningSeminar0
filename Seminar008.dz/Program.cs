using static System.Console;


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void OrderedString(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix.GetLength(1) - 1; k++)

//         if (matrix[i, k] < matrix[i, k + 1])
//         {
//           int temp = matrix[i, k + 1];
//           matrix[i, k + 1] = matrix[i, k];
//           matrix[i, k] = temp;
//         }
//     }
//   }

// }



// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine("\nОтсортированный массив:");
// OrderedString(matrix);
// PrintMatrix(matrix);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[] SumElementString(int[,] matrix)
// {
//   int[] SumRow = new int[matrix.GetLength(0)];

//   int sum = 0;

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       sum += matrix[i, j];
//     }
//     SumRow[i] = sum;
//   }
//   return SumRow;
// }


// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// int[] sumArray = SumElementString(matrix);
// // System.Console.WriteLine($"[{string.Join(", ", sumArray)}]");
// // System.Console.WriteLine();

// int min = sumArray[0];
// int index = 0;

// for (int i = 1; i < sumArray.Length; i++)
// {
//   if (sumArray[i] < min)
//   {
//     min = sumArray[i];
//     index = i;
//   }
// }
// Console.WriteLine($"Строка с минимальной суммой элементов {index + 1}");
// Console.ReadKey();



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] MatrixRandomNumber(int row, int column, int layer)
// {
//   int[,,] array = new int[row, column, layer];
//   Random rnd = new Random();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         array[i, j, k] = rnd.Next(10, 100);
//       }
//     }
//   }
//   return array;
// }

// void PrintMatrixArray3D(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//       }
//       Console.WriteLine();
//     }
//   }
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во слоев: ");
// int layer = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = MatrixRandomNumber(row, column, layer);
// PrintMatrixArray3D(matrix);
// Console.WriteLine();



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] Matrix(int[,] arrA, int[,] arrB)
// {
//   int[,] temp = new int[arrA.GetLength(0), arrB.GetLength(1)];

//   for (int i = 0; i < arrA.GetLength(0); i++)
//   {
//     for (int j = 0; j < arrB.GetLength(0); j++)
//     {
//       for (int k = 0; k < arrB.GetLength(1); k++)
//       {
//         temp[i, k] += arrA[i, j] * arrB[j, k];

//       }

//     }

//   }
//   return temp;
// }


// int[,] arrA = { { 2, 4 }, { 3, 2 } };
// int[,] arrB = { { 3, 4 }, { 3, 3 } };
// int[,] temp = Matrix(arrA, arrB);

// for (int i = 0; i < arrA.GetLength(0); ++i)
// {
//   for (int j = 0; j < arrB.GetLength(1); ++j)
//   {
//     Console.Write(temp[i, j] + " ");
//   }
//   Console.WriteLine();
// }

