/*Задача 69: Напишите программу, которая на вход принимает
 два числа A и B, и возводит число А в целую степень B 
 с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/ 

int GetForUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetDigitInStepen(int digit, int stepen)
{
    if (stepen ==1)
    {
        return digit ;
    }
    return digit * GetDigitInStepen(digit, stepen - 1);
}

int digit = GetForUserData("Введите число :");
int stepen = GetForUserData("Введите степень, в которую надо возвести число :");

int digitInStepen = GetDigitInStepen(digit,stepen);

Console.WriteLine(digitInStepen);
