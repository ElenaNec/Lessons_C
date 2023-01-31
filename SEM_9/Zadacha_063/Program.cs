/*Задача 63: Задайте значение N.
Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

int GetForUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userNumber = GetForUserData("Введите значение границу ряда");
PrintRange(userNumber);

void PrintRange(int N)
{
    if (N == 0)
    {
        return;
    }
    PrintRange(N - 1);
    Console.Write(N + ",");
}