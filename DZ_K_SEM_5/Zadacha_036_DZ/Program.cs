/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

// сумма элементов, стоящих на нечётных позициях
int SumOfNumberOddPosition(int[] array)
{
    int sum = array[0];

    for (int i=2; i < array.Length; i= i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = getUserData("Введите количество эл-тов массива: ");
int[] array = FillArray(length, 0, 99);
printArray(array);
int Sum =  SumOfNumberOddPosition(array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {Sum}");
