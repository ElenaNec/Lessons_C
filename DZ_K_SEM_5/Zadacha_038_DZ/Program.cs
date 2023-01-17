/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/ 

Console.Clear();

int[] FillArray(int length,int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start,end + 1);
    }
    return array;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i=0 ; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

// получение максимального значения
int getMax(int[] array)
{
    int max = array[0];
    for (int i=0; i < array.Length-1; i++)
    {
        if (array[i+1] > max)
        {
            max = array[i+1];
        }
    }
    return max;
}

//получение минимального значения
int getMin(int[] array)
{
    int min = array[0];
    for (int i=0; i < array.Length-1; i++)
    {
        if (array[i+1]< min)
        {
            min = array[i+1];
        }
    }
    return min;
}

//получение разницы между макс и мин значением 
int getMaxAndMin(int max, int min)
{
    int result = max - min;
    return result;
}

int length = getUserData("Введите количество эл-тов массива: ");
int[] array = FillArray(length, 0, 99);
printArray(array);
int max =  getMax(array);
int min = getMin(array);
int result =  getMaxAndMin(max, min);
Console.WriteLine($" Мин значение массива = {min}");
Console.WriteLine($" Макс значение массива = {max}");
Console.WriteLine($"Разница между макс и мин значениями массива = {result}");