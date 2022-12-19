// Метод возвращающий позицию (индекс) массива

int Indexof(int[] collection, int find )
{
    // определяем кол-во эл-тов
    int count = collection.Length;
    int index = 0;
    int position = 0;

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