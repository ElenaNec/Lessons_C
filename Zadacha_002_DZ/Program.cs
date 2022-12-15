// Написать программу, которая на вход принимает два числа и выдает максимальное
Console.Clear();
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
   Console.WriteLine($"Число {number1} максимальное"); 
}
else
{
    Console.WriteLine($"Число {number2} максимальное");
};