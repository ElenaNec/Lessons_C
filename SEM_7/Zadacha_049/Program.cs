/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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

int[,] GetNewArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength,rowLength]; 
    for (int i=0; i<colLength; i++)
    {
        for (int j=0; j<rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1);
            if (i%2==0 && j%2==0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
            else
            {
                array[i,j] = array[i,j];
            }
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
int[,] array = GetNewArray(n,m,0,10);
Print2DArray(array);
