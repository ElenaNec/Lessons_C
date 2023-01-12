/* Задача 30: Напишите программу, которая выводит 
массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
Console.Clear();

int getUserData(string message)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(message);
Console.ResetColor();
int UserData = int.Parse(Console.ReadLine()!);
return UserData;
}

int getRandom()
{
    return new Random().Next(0,2); // Next не учитывает вторую границу,
                                   // поэтому что бы выбиралось из двух 
                                   //элементов нужно вторую границу ставить 
                                   //на 1 больше
}

int[] createMassive(int numberOfArray)
{
    int[] rezult = new int[numberOfArray];
    for (int i = 0; i< numberOfArray; i++)
    {
        rezult[i] = getRandom();
    }
    return rezult;
}


string PrintArray(int[]array)
{
    string rezult = "[";
    string end = "]";
    for (int i = 0; i < array.Length; i ++)
    {
        if (i < array.Length-1)
        {
           
            rezult = rezult + $"{array[i]},";
        }
        else 
        {
        rezult = rezult + $"{array[i]}" + end;
        }
    }
    return rezult;
}
   
int numberOfArray = getUserData("Введите количество элементов: ");
int[] array =createMassive(numberOfArray);
string strArray = PrintArray(array);
Console.WriteLine(strArray);
