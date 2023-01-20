/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] ReadArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
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

// Количество чисел больших 0
int CountPositiveNumber(int[] array)
{
    int count = 0;

    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = getUserData("Введите количество эл-тов массива: ");
Console.WriteLine("Введите эл-ты массива: ");
int[] array = ReadArray(length);
printArray(array);
int count =  CountPositiveNumber(array);
Console.WriteLine($"Колтичество чисел > 0 = {count}");
