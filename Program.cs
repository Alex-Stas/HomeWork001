// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Please enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Please enter second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine($"{number1} is greater");
else
    Console.WriteLine($"{number2} is greater");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.Write("Please enter first number: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Please enter second number: ");
// int number2 = int.Parse(Console.ReadLine());
// Console.Write("Please enter third number: ");
// int number3 = int.Parse(Console.ReadLine());

// int max = number1;

// if (number1 > max) max = number1; 
// if (number2 > max) max = number2;
// if (number3 > max) max = number3; 
// Console.WriteLine($"{max} is the greatest");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Please enter number: ");
// int number = int.Parse(Console.ReadLine());

// if (number%2 == 0) Console.Write("Number is even");
// else Console.Write("Number is odd");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// Console.Write("Please enter number: ");
// int number = int.Parse(Console.ReadLine());
// if (number <= 1) Console.Write("There's no such numbers.");
// else
// {
//     int i = 2;
//     while (i <= (number - 2))
//     {
//         Console.Write($"{i}, ");
//         i = i + 2;
//     }
//     Console.Write($"{i}");
// }
