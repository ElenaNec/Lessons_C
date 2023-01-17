/*
Задача 31
Задать массив из 12 эл-тов, заполеный случ числами из промежутка
[-9;9]. Найти сумму отрицательных чисел
*/ 

int [] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (i=0; i < length; i++)
    {
        result[i]= new Random().Next(start, end + 1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write()
}

// Получаем сумму положительных 
int getSumOfPositive(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.length; i++)
    {
        if (array[i]>0)
        {
            sum+= array[i];
        }
    }
    return sum
}

// Получаем сумму отрицательных

int getSumOfNegative(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.length; i++)
    {
        if (array[i] < 0)
        {
            sum+= array[i];
        }
    }
    return sum
}
// сумма положит и отрицат сразу; flag =  1 - положит; flag = -1 - отрицатет

int getSumOfPositiveORNegative(int[] array, int flaf = 1)
{
    int sum=0;
    for (int i = 0; i < array.length; i++)
    {
        if (array[i]*flag > 0)
        {
            sum+= array[i];
        }
    }
    return sum
}
int[] array = generateArray(12,-9,9);
printArray(array);
SumOfPositive = getSumOfPositiveORNegative(array,1);
SumOfNegative = getSumOfPositiveORNegative (array,-1);
Console.WriteLine($"Сумма положительных" SumOfPositive );

