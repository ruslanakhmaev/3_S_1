// Задача 18. 
// Напишите программу, 
//которая по заданому номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string number = Console.ReadLine();

string quarter = Quarter(number);

Console.WriteLine($"{quarter}");

string Quarter(string num)
{
    // if (num == 1) return "x > 0 и y > 0";
    // if (num == 2) return "x < 0 и y > 0";
    // if (num == 3) return "x < 0 и y < 0";
    // if (num == 4) return "x > 0 и y < 0";
    // return "Некорректный ввод";

    switch (num) // отличия от  if, это то что не надо ни с чем сравнивать, есть уже все данные и просто необходимо вывести их.
    {
        case "1": return "x > 0 и y > 0";
        case "2": return "x < 0 и y > 0";
        case "3": return "x < 0 и y < 0";
        case "4": return "x > 0 и y < 0";
        default: return "Некорректный ввод";
    }
}