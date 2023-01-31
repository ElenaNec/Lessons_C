/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

формула ф-и Аккермана:
A(m,n)= n+1 при m=0
A(m,n)= A(m-1,1) при m>0, n=0
A(m,n)= A(m-1,A(m,n - 1) при m>0, n>0
*/ 

int GetForUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int FunctionOfAkkerman(int m, int n)
{
    if ( m == 0)
    {
        return n+1;
    }
    
    
    else    if ( m>0 && n == 0)
        {
            return FunctionOfAkkerman(m-1,1);
        }
   
    else
    {
        return FunctionOfAkkerman(m-1, FunctionOfAkkerman(m,n-1));
    }
}

int m = GetForUserData("Введите значение m:");
int n = GetForUserData("Введите значение n:");

int result = FunctionOfAkkerman(m,n);

Console.WriteLine($"Функция Аккермана  A({m},{n}) = {result}");
