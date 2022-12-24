/*
Задача 23
Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

//  функция выводит сообщение и считывает введенное с клавиатуры число
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// функция возводит в куб все числа от 1 до заданного числа
void kub(int n)
{
    for (int i = 1; i < n + 1; i= i + 1)
    {
        int temp = i * i * i;
        if ( i < n )
        {
            Console.Write($" {temp},");
        }
        else           // для того, чтобы после последней цифры не было запятой
        { 
            Console.Write($" {temp}");
        }
    }
}
int n = GetUserValue("Введите n: ");
kub(n);