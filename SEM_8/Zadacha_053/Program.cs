/*Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую
 и последнюю строку массива.*/

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
/*
//ф-я меняет местами двa любых столбца массива
int[,] SwapRows(int[,] array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tmp = array[i,row1];
        array[i,row1] = array[i,row2];
        array[i,row2] = tmp;
    }
    return array;
}*/

//ф-я меняет местами две любые строчки массива
int[,] SwapRows(int[,] array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[row1,i];
        array[row1,i] = array[row2,i];
        array[row2,i] = tmp;
    }
    return array;
}

int[,] array = Generate2DArray(10, 7, -5, 10);
PrintArray(array);
int[,] swappedArray = SwapRows(array,0, array.GetLength(0)-1);// if для столбцов, то array.GetLength(1)-1
PrintArray(swappedArray);