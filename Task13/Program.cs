/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

//Метод
int ThirdNum(int number)
{
    return number % 10;
}

//Основной код
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine(ThirdNum(num));
}
else Console.WriteLine("Третьей цифры нет");