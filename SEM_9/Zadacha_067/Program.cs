/*Задача 67: Напишите программу, 
которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45 -> 9*/ 

int GetForUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetSumDigit(int userNumber)
{
    if (userNumber == 0)
    {
        return 0;
    }
    return userNumber % 10 + GetSumDigit(userNumber/10);
}

int userNumber = GetForUserData("Введите число: ");
int summaDigit= GetSumDigit(userNumber);
Console.WriteLine(summaDigit);