// Задача 24


int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for(int i = start; i<= end; i++)
    {
        sum += i; 
    }
    return sum;
}

void showData(string messageStart, int data, string messageEnd)
{
    Console.WriteLine(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int end = getUserData(В число А для получения суммы);
int sum = getSumOfRange(1,end);