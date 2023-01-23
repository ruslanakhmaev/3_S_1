﻿// 17. Напиштите программу, еоторая принимает 
// 1. на вход координаты точки (X и Y),
// 2. причем X не равно 0 и Y не равно 0 и
// 3. выдает номер четверти плоскости, в которой находиться эта 
//точка. 

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 
            ? $"Указанные координаты соответствуют четверти -> {quarter}" 
            : "Введены некоректные координаты";
Console.WriteLine(result);

int Quarter(int xc, int yc) // Метод. 
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}