﻿/* 
Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.

Пример
5 -> 2, 4
8 -> 2, 4, 6, 8 
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int count = 2; count <= number; count += 2)
{
    Console.Write(count);
    if (count <= number - 2)
    {
        Console.Write(" ");
    }
}