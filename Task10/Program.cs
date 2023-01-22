/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
Пример: 
456 -> 5
782 -> 8
918 -> 1 */

//Метод
int SecondNum(int number)
{
    return number / 10 % 10;
}

//Основной код
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SecondNum(num);

if (num / 100 > 0 && num / 100 < 10)
{
    Console.WriteLine(SecondNum(num));
}
else 
{
    Console.WriteLine("Число не трехзначное");
}
