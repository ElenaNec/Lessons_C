/*
21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

//  функция выводит сообщение и считывает введенное с клавиатуры число (величину)
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int x1 = GetUserValue("Веедите x1: ");
int y1 = GetUserValue("Веедите y1: ");
int x2 = GetUserValue("Веедите x2: ");
int y2 = GetUserValue("Веедите y2: ");

double sqrt = Math.Sqrt((x2-x1)*(y2-y1)); // вычисляет квадратный корень из выражения
double sqrt1 = Math.Round(sqrt,2); // отделяет 2 символа после запятой
Console.WriteLine($"Расстояние = {sqrt1}");