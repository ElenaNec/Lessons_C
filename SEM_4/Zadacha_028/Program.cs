/*
Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

Console.Clear();

int getUserDatа(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getExtOfRange (int start, int end)
{
int ext = 1;
    for (int i = start; i<=end;i++)
    {
        ext = ext*i  ;
    }
    return ext;
}
int end = getUserDatа("Введите число: ");
int ext = getExtOfRange(1,end);
Console.Write($"Произведение всех чисел от 1 до {end} = ");
Console.WriteLine(ext);