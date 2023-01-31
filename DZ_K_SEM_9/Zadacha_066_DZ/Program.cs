/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/ 

int GetForUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetSumNumber(int start, int finish)
{
    if ( start == finish)
    {
        return start;
    }
    return start + GetSumNumber(start + 1, finish);
}

int userNumberStart = GetForUserData("Введите значение начало ряда");
int userNumberFinish = GetForUserData("Введите значение границу ряда");

int start = Math.Min(userNumberStart,userNumberFinish);
int finish = Math.Max(userNumberStart,userNumberFinish);

int sum = GetSumNumber(start,finish);

Console.WriteLine($"Сумма чисел от {start} до {finish} = {sum} ");
