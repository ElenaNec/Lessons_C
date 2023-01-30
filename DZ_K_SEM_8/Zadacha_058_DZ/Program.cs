/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

void Print2DArray(int[,] array)
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


// ф-я находит произведение двух матриц
int[,] GetProizvedenieMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i,j] = 0;

                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
        }
    }
    return arrayC;
}


int[,] arrayA = Generate2DArray(2, 2, 2, 4);
int[,] arrayB = Generate2DArray(2, 2, 2, 3);
Print2DArray(arrayA);
Print2DArray(arrayB);
int[,] arrayC = GetProizvedenieMatrix(arrayA, arrayB);
Print2DArray(arrayC);


