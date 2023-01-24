/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/ 

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Функция печатающая цветом
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] Get2DIntArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength,rowLength]; 
    for (int i=0; i<colLength; i++)
    {
        for (int j=0; j<rowLength; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{   
    // Печать номеров столбцов
    // "\t" - это знак табуляции, 
    //что бы не зависимо от размера цифры табличка получалась красивая

    Console.Write(" \t");
    for (int j=0; j<array.GetLength(1); j++)
    {
         printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i=0; i<array.GetLength(0); i++)
    {
        // Печать номеров строк
        printInColor( i + "\t");
        for (int j=0; j<array.GetLength(1); j++)
        {       
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int n = GetDataFromUser("Введите количество строк:");
int m = GetDataFromUser("Введите количество столбцов:");
int[,] array = Get2DIntArray(n,m,0,100);
Print2DArray(array);
