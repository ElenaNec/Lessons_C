//*12 Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно 

Console.Clear();

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

// метод нахождения остатка от деления
int KratnieChisla(int number1, int number2)
{   int ostatok = number1 % number2;
    return ostatok;
}

int ost = KratnieChisla(number1,number2);
if ( ost == 0)
{
     Console.WriteLine($"Числа {number1} и {number2} кратны");
}
else
{
    Console.WriteLine($"Числа {number1} и {number2} не кратны, остаток от деления {ost}");
}
