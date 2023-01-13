/* Задача 26
Напишите программу, которая принимает на вход число и 
выдает количество цифр в числе */

Console.Clear();

int getUserData(string message)
{
    // Вывод сообщения синим цветом
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getNumberOfDigit(int number)
{
    int numberOfDigit = 0;
    while (number > 0)
    {
        number = number / 10;
        numberOfDigit++;
    }
    return numberOfDigit;
}

void showData(string messageStart, int data)
{
    // Вывод сообщения красным цветом
    Console.ForegroundColor = ConsoleColor.DarkRed; 
    Console.Write(messageStart);
    // Вывод результата зеленым цветом
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите число: ");
int numberOfDigit = getNumberOfDigit(number);
showData($"В числе {number} количество цифр = ", numberOfDigit);