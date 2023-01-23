/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

//Метод
bool WeekEnd(int number)
{
   return number > 5 && number < 8; // добавил в метод часть кода "&& number < 8" для проверки на допустимый диапазон
}

//Основной код
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = WeekEnd(num);

string res = result ? "Да" : "Нет";
Console.WriteLine(res);