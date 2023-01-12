// Задача 26

int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getNumberOfDigit(int number)
{
    int getNumberOfDigit = 0;
    while (number > 0)
    {
        number = number / 10;
        numberOfDigit++;
    }
    return numberOfDigit;
}

void showData(string messageStart, int data, string messageEnd)
{
    Console.WriteLine(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int number = getUserData("Введите ");
int numberOfDigit = getNumberOfDigit(number);
showData($"В числе {number} = ", numberOfDigit);