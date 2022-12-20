/*
Задача 13: Напишите программу, 
которая выводит третью цифру
заданного числа или сообщает,
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
// функция получения случайного числа
int GetRangeNumber(int start, int end)
{
    int number = new Random().Next(1,end+1);
    return number;
}


// функция нахождения третьей цифры в числе
int ShowThirdDigit(int number)
{
    while (number - 999 >= 0)
    {
        number = number/ 10; // в результате number должен стать трехзначным числом
    }
    int digit3 = number % 10; // Выделяю третью цифру
 
    return digit3;
}

int rangeNumber = GetRangeNumber(1,9999999);
int thirdDigit = ShowThirdDigit(rangeNumber);
if (rangeNumber >= 100)
{
    Console.WriteLine($"Цифра {thirdDigit} является третьей цифрой числа {rangeNumber}");
}
else
{
    Console.WriteLine($"В числе {rangeNumber} нет третьей цифры");
}