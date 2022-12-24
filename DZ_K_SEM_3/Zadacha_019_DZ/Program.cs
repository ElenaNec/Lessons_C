/*
Задача 19
Напишите программу, которая принимает 
на вход пятизначное число и 
проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/ 

Console.Clear();

//  функция выводит сообщение и считывает введенное с клавиатуры число
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number = GetUserValue("Веедите число: ");

// функция подсчета кол-ва цифр в числе
int QuantityDigit(int number)
{
    int quantity = 0;
    int i = 0;
    while (number >= 10)
    {
        number = number / 10;
        i++;
    }
    quantity = i+1;
    return quantity;
    }
int quantityDigit = QuantityDigit(number);
// Console.Write($" {quantityDigit}"); - выводит на консоль сколько в числе цифр

// функция нахождения симметрии в числе (является ли число полиндромом)
int Polindrom(int number, int quantityDigit)
{
    int count = quantityDigit / 2;  // делим число по-полам чтобы узнать кол-во сравнений
    int flag = 0;
    
        int number1 = 0;
        int numberEnd = 0;
        int numberNext = 0;
        int numberEndNext = 0;
        
    for (int i=0; i < count; i++)
    {    
        number1 = number / ((int)Math.Pow(10,quantityDigit-(i+1)));
        numberEnd = number % ((int)Math.Pow(10,i+1));
        if (number1 == numberEnd)
        {
            for (i=i+1; i < count; i++)
            {
                numberNext = (number / ((int)Math.Pow(10,quantityDigit-(i+1)))) % 10;
                numberEndNext = (number / ((int)Math.Pow(10,i))) % 10;
                if (numberNext == numberEndNext)
                {
                    flag = 1;
                }
                else 
                {
                    flag = 0;
                break;
                }
            
            }
        }
        else 
        {
            flag = 0;
        }
    }
    return flag;
}

int Flag = Polindrom(number, quantityDigit);
if (Flag == 1)
{
    Console.WriteLine($"Число {number} является полиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является полиндромом"); 
}