/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();

int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(message);
Console.ResetColor();
int UserData = int.Parse(Console.ReadLine()!);
return UserData;
}

int getRandom()
{
    return new Random().Next(0,100); // Next не учитывает вторую границу,
                                   // поэтому что бы выбиралось из двух 
                                   //элементов нужно вторую границу ставить 
                                   //на 1 больше
}

int[] createArray(int numberOfArray)
{
    int[] rezult = new int[numberOfArray];
    for (int i = 0; i< numberOfArray; i++)
    {
        rezult[i] = getRandom();
    }
    return rezult;
}


string PrintArray(int[]array)
{
    string rezult = "[";
    string end = "]";
    for (int i = 0; i < array.Length; i ++)
    {
        if (i < array.Length-1)
        {
           
            rezult = rezult + $"{array[i]},";
        }
        else 
        {
        rezult = rezult + $"{array[i]}" + end;
        }
    }
    return rezult;
}
   
int numberOfArray = getUserData("Введите количество элементов массива: ");
int[] array =createArray(numberOfArray);
string strArray = PrintArray(array);
Console.WriteLine(strArray);
