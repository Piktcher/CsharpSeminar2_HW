﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 999);
Console.WriteLine(num);

int second_digit = num / 10 % 10;

Console.WriteLine("Вторая цифра числа равна " + second_digit);