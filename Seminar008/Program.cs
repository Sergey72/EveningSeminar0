﻿using static System.Console;

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

// void ReplacArrayString(int[,] array)
// {
//   int tempArray = 0;

//   for (int i = 0; i < array.GetLength(1); i++)
//   {
//     tempArray = array[0, i];
//     array[0, i] = array[array.GetLength(0) - 1, i];
//     array[array.GetLength(0) - 1, i] = tempArray;

//   }

// }





// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// ReplacArrayString(matrix);
// PrintMatrix(matrix);


// Вариант №2

// int[,] FillMatrixWithRandom(int row, int column)
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
//     Console.WriteLine();
//   }
// }

// int[,] SwitchRows(int[,] matrix)
// {
//   int temp = 0;

//   for (int i = 0; i < matrix.GetLength(1); i++)
//   {
//     temp = matrix[0, i];
//     matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//     matrix[matrix.GetLength(0) - 1, i] = temp;
//   }
//   return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// SwitchRows(matrix);
// PrintMatrix(matrix);


// Задача 55: Задайте двумерный массив.
//Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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



// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);

// int[,] TempArray = new int[column, row];

// for (int i = 0; i < TempArray.GetLength(0); i++)
// {
//   for (int j = 0; j < TempArray.GetLength(1); j++)
//   {
//     TempArray[i, j] = matrix[j,i];
//   }

// }

// System.Console.WriteLine();
// PrintMatrix(TempArray);



// int[,] FillMatrixWithRandom(int row, int column)
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
//     Console.WriteLine(" ");
//   }
// }



// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// int[,] resultMatrix = new int[column, row];
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//   for (int j = 0; j < resultMatrix.GetLength(1); j++)
//   {
//     resultMatrix[i, j] = matrix[j, i];
//   }
// }
// System.Console.WriteLine();
// PrintMatrix(resultMatrix);



// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Первый вариант решения


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

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();


// int count = 0;
// int size = row * column;
// for (int dictionary = 0; dictionary < size; dictionary++)
// {
//   count = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (matrix[i, j] == dictionary)
//       {
//         count++;
//       }
//     }
//   }
//   if (count > 0)
//   {
//     Console.WriteLine($"{dictionary} встречается {count} раза");
//   }

// }


// Первый вариант решения


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

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();

// int[] FrequencyDictionary = new int [row*column];

// for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       FrequencyDictionary[matrix[i,j]] ++;
//     }
//   }
//   for (int i = 0; i < FrequencyDictionary.Length; i++)
//   {
//     if (FrequencyDictionary[i]!= 0)
//     {
//       Console.WriteLine($"{i} встречается {FrequencyDictionary[i]} раза");
//     }
//   }