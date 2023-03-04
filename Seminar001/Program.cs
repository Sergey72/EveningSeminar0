// Task 1.
/*
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if (number1 == quad2)
{
  Console.WriteLine("Yes!");
}
else
{
  Console.WriteLine("No!");
}
*/

// Task 2. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в прмежутке от -N до N.

/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
  Console.Write(current + " ");
  current += 2; // Если увеличить на 2 то можно писать current += 2; или current = current + 2;
}
*/

// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее. 


// Console.Write("Input a first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 < number2)
// {
//   Console.Write("max = " + number2);
// }
// else
// {
//   Console.Write("max = " + number1);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


// Console.Write("Input a first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a third number: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;

// if(max < number2)
// {
//   max = number2;
// }
// else
// {
//   if(max < number3)
//   {
//     max = number3;
//   }
// }
//  Console.Write(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введи любое целое число, и узнаешь, четное оно или нет: ");
int num = Convert.ToInt32(Console.ReadLine());

int even = num % 2;

if(even == 0)
{
  Console.WriteLine($"Да, {num} четное число");
}
else
{
  Console.WriteLine($"Нет, {num} не четное число");
}



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


// Console.Write("Введи любое целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 1;

// while (current <= num)
// {
//   if (current % 2 == 0)
//   {
//     Console.Write(current + " ");
//   }
//   current ++;
  
// }


