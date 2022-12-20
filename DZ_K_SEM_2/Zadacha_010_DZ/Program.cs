/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// функция получения случайного числа из числового отрезка
int GetRangeNumber(int start, int end)
{
    int number = new Random().Next(start,end+1);
    return number;
}

// функция нахождения второй цифры в числе
int ShowSecondDigit(int number)
{
    int digit1 = number / 100; // Выделяю первую цифру
    int digit2 = number / 10;  // Выделяю первые две цифры
    int digit3 = digit1 * 10;  
    int result= digit2 - digit3;
    return result;
}
int rangeNumber = GetRangeNumber(100,999);
int secondDigit = ShowSecondDigit(rangeNumber);
Console.WriteLine($"Цифра {secondDigit} является второй цифрой числа {rangeNumber}");