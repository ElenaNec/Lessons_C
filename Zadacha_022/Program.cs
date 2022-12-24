/*
22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
//  функция выводит сообщение и считывае введенное с клавиатуры число
int getuserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// функция возводит в квдрат все числа от 1 до заданного числа
void kvadrat(int n)
{
    for (int i = 1; i < n + 1; i= i + 1)
    {
        int temp = i * i;
        if ( i < n )
        {
            Console.Write($" {temp},");
        }
        else
        { 
            Console.Write($" {temp}");
        }
    }
}
int n = getuserValue("Введите n: ");
kvadrat(n);