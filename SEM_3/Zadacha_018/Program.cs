/*
Напишите программу, кот по заданному номеру чеверти 
показывает диапазон возможных координат точки в этой четверти
*/


int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string GetRageFromQuatre(int quarter)
{
    string result = $"Диапазон значений в {quarter} четверти ";
    switch (quarter)
    {
        case 1 :
        {
            result += "x>0 и y>0"; 
            break;
        }
        case 2 :
        {
            result += "x<0 и y>0"; 
            break;
        }
        case 3 :
        {
            result += "x<0 и y<0"; 
            break;
        }
        case 4 :
        {
            result += "x>0 и y<0"; 
            break;
        }
        default:
        {
            result = $"Такой четверти не существует";
            break;
        }
    }
    return result;
}

int quarter = GetUserValue("Введите номер четверти");
string rangeDescription = GetRageFromQuatre(quarter);
Console.WriteLine(rangeDescription);