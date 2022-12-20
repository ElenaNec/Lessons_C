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
    int index = 1;
    int temp = 0;
    while (number/index - 999 >= 0)
    {
        number = number/(index * 10);
        temp = number; // в результате temp должен стать трехзначным числом
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