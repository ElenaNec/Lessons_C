// Написать программу, которая на вход принимает три числа и выдает максимальное
Console.Clear();
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine($"Число {number1} максимальное");
    }    
    else
    {
        Console.WriteLine($"Число {number3} максимальное"); 
    }
}

else
{
    if (number2 > number3)
    {
        Console.WriteLine($"Число {number2} максимальное");
    }
    else
    {
        Console.WriteLine($"Число {number3} максимальное");
    }
};