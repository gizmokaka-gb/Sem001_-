﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число: ");
int num = int.Parse (Console.ReadLine());

if (num % 2 == 0) Console.WriteLine($"{num} является четным числом.");
else Console.WriteLine($"{num} не является четным числом.");
