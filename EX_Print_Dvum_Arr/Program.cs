// Заполнение случайными числами и печать двумерного массива 

Console.Clear();

// Метод печати двумерной матрицы
void printArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++) // matr.GetLength(0) Возвращает кол-во строк в массиве
    {
    for (int j=0; j<matr.GetLength(1); j++) //matr.GetLength(1) Возвращает кол-во столбцов в массиве
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();    
    }
}
 
 //Метод заполнения массива случайными числами
void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1,10)
        }
    }
}

int[,] matrix = new int[3,4];
printArray(matrix);
Console.WriteLine();
FillArray(matrix);
printArray(matrix);
