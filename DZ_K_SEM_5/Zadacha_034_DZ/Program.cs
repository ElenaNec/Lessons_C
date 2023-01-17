/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

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

// Количество четных чисел
int CountEvenNumber(int[] array)
{
    int count = 0;

    for (int i=0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}

int length = getUserData("Введите количество эл-тов массива: ");
int[] array = FillArray(length, 100, 999);
printArray(array);
int count =  CountEvenNumber(array);
Console.WriteLine($"Колтичество четных чисел в массиве = {count}");
