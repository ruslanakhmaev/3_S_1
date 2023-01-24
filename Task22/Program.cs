// Напишите программму, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);

// Метод.
void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5}  {count * count, 5}");
        count++;
    }
}