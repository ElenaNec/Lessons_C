/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.*/ 

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
/*
//Функция получения случайного вещественного массива (у числа два знака после запятой)
double[,] Get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength,rowLength];
    int divider = 100; // Делитель 
    for (int i=0; i<colLength; i++)
    {
        for (int j=0; j<rowLength; i++)
        {
            ///Используем констукцию, которая будет давать число с думя знаками после запятой
            сперва умножим каждый диапазон на divider, а потом разделим получившееся число на divider
             + 0.0 сделали что бы число divider стало double и деление стало не целочисленным
            ///
            
            array[i,j] = new Random().Next(start* divider, (finish+1) * divider)/(divider + 0.0); 
            
        }
    }
    return array;
}
*/

//Функция получения случайного вещественного массива (у числа два знака после запятой)
//Такая функция проще, чем придыдущая
double[,] Get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength,rowLength]; 
    for (int i=0; i<colLength; i++)
    {
        for (int j=0; j<rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1) + Math.Round(new Random().NextDouble(),2); 
        }
    }
    return array;
}

void Print2DArray(double[,] array)
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
double[,] array = Get2DDoubleArray(n,m,0,100);
Print2DArray(array);
