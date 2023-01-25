/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] GetArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

int GetZnachenieElement(int[,] array, int k, int l)
{
    int result = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == k-1 && j == l-1)
            {
                result = array[i, j];
            }
        }
    }
    return result;
}

void Print2DArray(int[,] array)
{
    // Печать номеров столбцов
    // "\t" - это знак табуляции, 
    //что бы не зависимо от размера цифры табличка получалась красивая

    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j+1 + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Печать номеров строк
        printInColor(i+1 + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int n = GetDataFromUser("Введите количество строк:");
int m = GetDataFromUser("Введите количество столбцов:");
int[,] array = GetArray(n, m, 0, 10);
Print2DArray(array);
int k = GetDataFromUser("Введите позицию строки искомого элемента:");
int l = GetDataFromUser("Введите позицию столбца искомого элемента:");
int result = GetZnachenieElement(array, k, l);

if (result == -1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Такого элемента в массиве нет!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Значение эл-та в строке {k}, столбце {l} = {result}");
    Console.ResetColor();
}
