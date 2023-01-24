/* Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 || number >= 100000 ) Console.WriteLine("Некорректный ввод");
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