/* Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
double digitCount1 = Math.Round(Math.Log10(num), 0, MidpointRounding.ToZero);
int count1 = Convert.ToInt32(digitCount1);
PalindromUniverse(num, digitCount1, count1);


void PalindromUniverse(double number, double digitCount, int count)
{
    double a = Math.Round(number / Math.Pow(10, count), 0, MidpointRounding.ToZero);
    double b = number % 10;

    if (a == b)
    {
        while (count > 0)
        {
            number = (number - (number % 10) - (Math.Round(number / Math.Pow(10, count), 0, MidpointRounding.ToZero) * Math.Pow(10, count))) / 10;
            count = count - 2;
            if (a == b)
            {
                a = Math.Round(number / Math.Pow(10, count), 0, MidpointRounding.ToZero);
                b = number % 10;
            }
        }
        if (a == b)
        {
            Console.WriteLine("Да");
        }
        else Console.WriteLine("Нет");
    }
    else Console.WriteLine("Нет");
}