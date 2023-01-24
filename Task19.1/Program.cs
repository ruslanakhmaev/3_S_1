/* Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
// double digitCount = Math.Round(Math.Log10(number), 0, MidpointRounding.ToZero);
if (number < 0) Console.WriteLine("Отрицательное число");
else Palindrom(number);

// Метод на 5-ти значное число.
void Palindrom(int num)
{
    if (num / 10000 == num % 10)
    {
        if ((num - (num / 10000 * 10000)) / 1000 == num % 100 / 10)
            Console.WriteLine("Число палиндром");
    }
    else Console.WriteLine("Число НЕ палиндром");
}


// bool PalindromUnivers(int num)
// {
//     while (Math.Round(num / Math.Pow(10, count), 0, MidpointRounding.ToZero) == num % 10)
//     // if (Math.Round(num / Math.Pow(10, Count), 0, MidpointRounding.ToZero) == num % 10)
//     {
//         count = count - 1;
//         Console.WriteLine(count);
//     }
//     else Console.WriteLine("Число НЕ палиндром");
// }
