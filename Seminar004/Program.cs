// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Sum(int A)
// {
//   int sum = 0;
//   for (int i = 1; i <= A; i++)
//   {
//     sum += i;
//   }
//   return sum;
// }


// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(number);
// System.Console.WriteLine($"Сумма от 1 до {number} = {sum}");

// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int Count(int num)
// {
//   int count = 0;
//   // int i = 1;
//   while (num != 0)
//   {
//     num /= 10;
//     count ++;
//   }

//   return count;

// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = Count(number);
// System.Console.WriteLine($"Количество цифр в числе {number} - {count}");

// Задача 28: Напишите программу, которая принимат на вход число N и выдает произведение чисел от 1 до N.

// int ScalarProduct(int num)
// {
//   int scalar = 1;
//   for (int i = 1; i <= num; i++)
//   {
//     scalar*= i;
//   }
//   return scalar;
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int product = ScalarProduct(number);
// System.Console.WriteLine($"Произведение чисел от 1 до {number} = {product}");

//  Задача 30: Напишите программу которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] arrayRandom(int size)
// {
//   int[] arr = new int[size];
//   Random rnd = new Random(); // объект класса
//   for(int i = 0; i < arr.Length; i++)  // arr.Length -длинна массива
//   {
//     arr[i] = rnd.Next(0, 2); //диапазон массива(от 0 до 1 - последний элемент не учитывается)
//   }
// return arr;
// }

// System.Console.WriteLine("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = arrayRandom(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]"); //метод для вывода массива на экран.

// Еще один вариант.

int Prompt(string message)
{
  System.Console.Write(message);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
  int[] array;
  array = new int [Length];
Random random = new Random();
for (int i = 0; i < Length; i++)
{
array[i] = random.Next(minValue, maxValue + 1);
}
return array;
}

void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length -1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.WriteLine("]");
}
int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);