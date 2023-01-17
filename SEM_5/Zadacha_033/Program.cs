/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

int[] generateArray(int length)
{
    int[] rezult = new int[length];
    for (int i = 0; i< length; i++)
    {
        rezult[i] = new Random().Next(length);
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

int lookForNumber(int[] array, int number)
{
    int index = -1;
    for (int i= 0; i < array.Length; i++)
    {
        if (array[i]== number)
        {
            index = i;
            break;
        }
    }
    return index;
}

int length = getUserNumber("Введите количество эл-тов массива:");
int[] array =  generateArray(length);
printArray(array);
int number = getUserNumber("Введите искомое число:");
int index = lookForNumber(array,number);
if (index >= 0 )
{
    Console.WriteLine($"Искомое число находится на позиции с индексом {index+1}");
}
else
{
    Console.WriteLine($"Такого числа нет в массиве");
}
