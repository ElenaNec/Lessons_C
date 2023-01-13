/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 

Console.Clear();

int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write(message);
Console.ResetColor();
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int getStepNumber(int number, int stepen)
{
    int i = 1;
    int rez = 1;
    if (stepen == 0)
    {
        number = 1;
    }
    /*if (stepen == 1)
    {
        number = number;
    } */
    else
    {
        while ( i <= stepen)
         {
            rez = rez * number; 
            i = i + 1;
         }
    }
    return rez;
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
int stepen = getUserData("Введите степень, в которую надо возвести число: ");
int stepenNumber = getStepNumber(number, stepen);
showData($"Число {number} в степени {stepen} = ", stepenNumber);