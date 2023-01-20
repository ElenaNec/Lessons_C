/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/ 


int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string getDigitFibonachi(int userData)
{
    string result = string.Empty;
    int n1 = 0;
    int n2 = 1;
    result = $"{n1},{n2}";

    if (userData==1)
    {
    result = $"{n1}";
    }
    if (userData==2)
    {
    result = $"{n1},{n2}";
    }

    for (int i = 2; i < userData; i++)
    {
        int n = n1 + n2;
        result = result + "," + n;
        n1 = n2;
        n2 = n;
    }
    return result;
}

int userData =  getUserData("Введите число :");
string result = getDigitFibonachi(userData);
Console.WriteLine($"Число Фибоначи = {result}");