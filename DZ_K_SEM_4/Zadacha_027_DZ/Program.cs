/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getSumDigit(int number)
{
    //int num = number;
    int temp =0;
    int sum = 0;
    if (number >1)
    {
        while ( number >= 1)
        {
           temp  =  number % 10;
            number = number / 10;
           sum = sum + temp;
        }
    }
    else 
    {
        sum = number;
    }    
    return sum;
}

void showData(string messageStart, int result)
{
    // Вывод сообщения красным цветом
    Console.ForegroundColor = ConsoleColor.DarkRed; 
    Console.Write(messageStart);
    // Вывод результата зеленым цветом
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(result);
    Console.ResetColor();
}

int number = getUserData("Введите число: ");
int summaDigit = getSumDigit(number);
showData($"Сумма цифр в числе {number}  = ", summaDigit);
