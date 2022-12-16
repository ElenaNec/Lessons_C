// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int index = 2;

if (number < index)
{
    Console.WriteLine($"Нет четных чисел");
}
while (index <= number)
{
    Console.Write($" {index} ");
    index = index + 2;
};