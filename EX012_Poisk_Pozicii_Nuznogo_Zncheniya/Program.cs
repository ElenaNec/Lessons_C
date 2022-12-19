// Задача Поиск позиции нужного эл-та массива

Console.Clear();

// Метод заполнения массива случайными числами
void FillArray(int[] collection )
{
    int length = collection.Length; // Определяем длину массива
    int index = 0;
    while ( index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

// Метод, который печатает массив
void PrintArray(int[] col )
{
    int count = col.Length; // Определяем количество элементов 
    int position = 0; // текущая позиция
    while ( position < count)
    {
        // выводим через значение текущего элемента ( col[position] )
        Console.WriteLine (col[position]);
        position++;
    }
}

// Метод возвращающий позицию (индекс) массива
int Indexof(int[] collection, int find )
{
    // определяем кол-во эл-тов
    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемента нет, значит, выйдет -1

    while ( index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  // Выход как только эл-т массива стал равен искомому числу
        }
        index++;
    }
    return position;
}

Console.WriteLine(" Введите искомое число ");
int N = int.Parse(Console.ReadLine()!); // int.Parse преобразует пересенную стринг(string) в интеджер(int)

int [] array = new int [10]; // означает «создай новый массив с 10-ю элементами»

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array,N);
Console.WriteLine(pos);