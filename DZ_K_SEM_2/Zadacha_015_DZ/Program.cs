/*
Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
// функция получения случайного числа
int GetRangeNumber(int start, int end)
{
    int number = new Random().Next(1,end+1);
    return number;
}

int rangeNumber = GetRangeNumber(1,7);

if (rangeNumber < 6)
{
    Console.WriteLine($"Цифра {rangeNumber} показывает, что сегодня рабочий день");
}
else
{
    Console.WriteLine($"Цифра {rangeNumber} показывает, что сегодня выходной день");
}