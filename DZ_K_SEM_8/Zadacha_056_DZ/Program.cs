/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Clear();

int[,] Generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void PrintHeadOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    PrintHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------");
}


// ф-я находит сумму строк
int[] SumLine(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result[i] = array[i, 0];

        for (int j = 1; j < array.GetLength(1); j++)
        {
            result[i] = result[i] + array[i, j];
        }
    }
    return result;
}

// получение индекса минимального значения
int GetNumberLineOfMinSum(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i=1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

void PrintSumArray(int[] result)
{
    Console.Write("Сумма строк = [");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
        if (i < result.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine("]");
}

int[,] array = Generate2DArray(4, 4, 1, 9);
PrintArray(array);

int[] sumLine = SumLine(array);
PrintSumArray(sumLine);
int minIndex = GetNumberLineOfMinSum(sumLine);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndex}");