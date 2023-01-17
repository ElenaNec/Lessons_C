/*
Задача 35 Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] generateArray(int length)
{
    int[] rezult = new int[length];
    for (int i = 0; i< length; i++)
    {
        rezult[i] = new Random().Next(123);
    }
    return rezult;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i=0 ; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i< array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getUserNumber(string N)
{
    Console.WriteLine(N);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int findCountNumber(int[] array,int start, int end)
{
    int index = 0;
    for (int i= 0; i < array.Length; i++)
    {
        if (array[i] <= end && array >= start)
        {
            index++;
        }
    }
    return index;
}

int length = getUserNumber("Введите количество эл-тов массива:");
int[] array =  generateArray(length);
printArray(array);
int numberStart = getUserNumber("Введите начало интервала:");
int numberEnd = getUserNumber("Введите конец интервала:");

int CountNumber = lookForNumber(array,numberStart, numberEnd);
if (index >= 0)
{
    Console.WriteLine($"Колтичество чисел из заданного диапазона = {index+1}");
}
else
{
    Console.WriteLine($"Нет чисел из заданного диапазона");
}