/*
Задача 32
Заменить в массиве все положительные эл-ты отрицательными
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

// Получаем 
int getIntFromUser(string message)
{
    Console.WriteLine(message)
}

int length = getIntFromUser(" Введите длину массива");
int[] array = generateArray(length, -100,100);
printArray(array);