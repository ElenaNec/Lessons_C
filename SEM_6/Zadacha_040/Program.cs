/*Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон */ 

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool IsTriangleExist(int a, int b, int c)
{
    bool isExist = false;
    if (a < b+c && b < c+a && c < b+a)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны a :");
int b = getUserData("Введите длину стороны b :");
int c = getUserData("Введите длину стороны c :");
bool isExist = IsTriangleExist(a,b,c);
Console.WriteLine($"Треугольник со сторонами [{a},{b},{c}]{((isExist)?"существует":"не существует")}");

/*
27 строку можно записать так:
string str = (isExist)?"существует":"не существует";

или так:

if (isExist)
{
    str = "существует";
}
else
{
    str = "не существует";
}

*/