/*Задача 45: Напишите программу, которая будет 
создавать копию заданного массива с помощью 
поэлементного копирования.*/ 

int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i< length; i++)
    {
        array[i] = new Random().Next(start, end +1);
    }
    return array;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
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

int[] CopyArray(int[] array)
{
    int[] result= new int[array.Length];
    for (int i= 0; i < array.Length; i++)
    {
        result[i]= array[i];
        
    }
    return result;
}

int length = getUserData("Введите количество эл-тов массива:");
int[] array =  generateArray(length,-10,10);
printArray(array);
int[] result = CopyArray(array);
printArray(result);

