// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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

// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент в массиве находитсяпо формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.


// int[,] MatrixRandomNumber(int row, int column)
// {
//   int[,] array = new int[row, column];
//   Random rnd = new Random();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = i + j;
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

// Задача 49:
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, изамените эти элементы на их квадраты.


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

// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент в массиве находитсяпо формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.


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
//     Console.WriteLine();
//   }
// }

// int[,] ValidMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i += 2)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j += 2)
//     {
//       matrix[i, j] *= matrix[i, j];
//     }

//   }
//   return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixRandomNumber(row, column);
// PrintMatrix(matrix);
// ValidMatrix(matrix);
// System.Console.WriteLine();
// PrintMatrix(matrix);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главнойдиагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int SumMainDiagonal(int[,] matrix)
{
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j)
      {
        sum += matrix[i, j];
      }
    }
  }
  return sum;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = MatrixRandomNumber(row, column);
PrintMatrix(matrix);
System.Console.WriteLine(SumMainDiagonal(matrix));

