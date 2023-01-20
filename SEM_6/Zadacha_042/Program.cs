/*Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10.*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string TransformBinary(int userData)
{
    string result = string.Empty;
    while (userData > 0)
    {
        result = userData%2 + result;
        userData = userData/2;
    }
    return result;
}

int userData =  getUserData("Введите число :");
string binary = TransformBinary(userData);
Console.WriteLine($"Число {userData} в доичной системе = {binary}");