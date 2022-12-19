// Метод заполнения массива случайными числами

void FillArray(int[] collection )
{
    int length = collection.Length;
    int index = 0;
    while ( index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);
