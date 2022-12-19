// Метод, который печатает массив

void PrintArray(int[] col )
{
    int count = col.Length;
    int position = 0;
    while ( position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);