/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

// Среднее арифмитическое каждого столбца
double[] GetAverageEveryСolumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    double[] temp = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp[j] = array[0, j];

        for (int i = 1; i < array.GetLength(0); i++)
        {
            temp[j] = temp[j] + array[i, j];

            if (i == (array.GetLength(0) - 1))
            {
                result[j] = temp[j] / (array.GetLength(0));
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
        printInColor(j  + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Печать номеров строк
        printInColor(i  + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void printArray(double[] result)
{
    Console.Write("[");
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

int n = GetDataFromUser("Введите количество строк:");
int m = GetDataFromUser("Введите количество столбцов:");
int[,] array = GetArray(n, m, 0, 10);
Print2DArray(array);
double[] result = GetAverageEveryСolumn(array);
Console.Write("Среднее арифмитическое = ");
printArray(result);


