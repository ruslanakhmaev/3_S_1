/* Задача 27: Напишите программу, которая 
1. принимает на вход число и 
2. выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: "); // 12345
int num = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToInt32(Math.Round(Math.Log10(num), 0, MidpointRounding.ToZero)); // 5
int sumNumbers = SumDigit(num, count);
Console.WriteLine($"Сумма цифр числа равна: {sumNumbers}");   

int SumDigit(int number, int counter)
{
    int sum = 0;
    for (int i = 0; i < counter + 1; i++)
    {
        int numSum = number % 10;
        sum = sum + numSum;
        number = number / 10;
    }
    return sum;
}