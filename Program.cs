﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
// }

// else
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input third number: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if(max < b)
// {
//     max = b;
// }

// if(max < c)
// {
//     max = c;
// }

// System.Console.WriteLine($"{a}, {b}, {c} -> {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a % 2 == 0)
// {
//     System.Console.WriteLine($"{a} -> да");
// }

// else
// {
//     System.Console.WriteLine($"{a} -> нет");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while(count <= n)
// {
//     if(count % 2 == 0)
//     {
//         System.Console.Write(count++ + " ");
//     }

//     else
//     {
//         count++;
//     }
// }