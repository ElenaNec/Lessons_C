/*
Написать программу, кот принимает на вход 
координаты (x,y), и выдает номер четверти,
в кот. находится эта точка
*/

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// ф-я нахождения четверти
int GetQarterNumber(int x, int y)
{
    int quarter = 0;
    if (x>0 && y>0)
    {
        quarter = 1;
    }
    else if (x<0 && y>0)
    {
        quarter = 2;
    }
    else if (x<0 && y<0)
    {
        quarter = 3;
    }
    else if (x>0 && y<0)
    {
        quarter = 4;
    }
    return quarter;
}

int userX = GetUserValue("Введите x: ");
int userY = GetUserValue("Введите y: ");
int quarter = GetQarterNumber(userX, userY);

if (quarter > 0)   // можно было написать if (userX !=0 && userY !=0)
{
    Console.WriteLine($"Точка [{userX},{userY}] находится в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка [{userX},{userY}] находится на оси координат");
}
