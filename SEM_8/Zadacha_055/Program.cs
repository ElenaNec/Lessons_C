/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна 
вывести сообщение для пользователя.*/ 


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

int GetDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

bool CheckCanRotate(int rows, int cols)
{
    return rows == cols;
}


int[,]  RotateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
        int tmp = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = tmp;
        }
    }
    return array;
}

int rows = GetDataFromUser("Введите количество строк:");
int cols = GetDataFromUser("Введите количество столбцов:");
bool canContinue = CheckCanRotate(rows, cols);


if (canContinue)
{
    int[,] array = Generate2DArray(rows, cols, 0, 50);
    PrintArray(array);
    int[,] rotateArray = RotateMatrix(array);
    PrintArray(rotateArray);
}
else
{
    printInColor($"Для переворота нужна квадратная матрица, вы ввели [{rows}:{cols}]", ConsoleColor.Red);
}