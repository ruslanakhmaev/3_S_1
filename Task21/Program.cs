﻿/* Напишите программу, которая 
1. принимает на вход координаты двух точек
2. и находит расстояние между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D: {distanceRound}");

// Метод
double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2) + Math.Pow((zc2 - zc1), 2));
}