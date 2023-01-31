/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void GetRange(int digit)
{
    if (digit == 0)
    {
        return;
    }
    Console.Write(digit + ", ");
    GetRange(digit-1);
}

int digit = GetUserData("Введите число :");
GetRange(digit);