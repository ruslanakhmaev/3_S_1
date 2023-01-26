/* Задача 29: Напишите программу, которая 
1. задаёт массив из 8 элементов и 
2. выводит их на экран.
Пример: 
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */


int[] GenerationArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int[] array = GenerationArray(8, 1, 33);
PrintArray(array);