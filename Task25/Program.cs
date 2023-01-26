/* Задача 25: Напишите цикл, который 
1. принимает на вход два числа (A и B) и 
2. возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int count; 
int numC = numA;

if (numB < 0)
{
    count = numB * -1;
}

else
{
    count = numB;
}

while (count > 1)
{
    numA = numA * numC;
    count--;
}
Console.WriteLine(numA);