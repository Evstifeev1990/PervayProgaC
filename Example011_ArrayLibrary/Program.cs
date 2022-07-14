void FillArray (int[] collection)
{
    int lenght = collection.Length;

    int index = 0;

    while(index<lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int len = col.Length;

    int possishion = 0;

    while(possishion<len)
    {
        Console.WriteLine(col[possishion]);
        possishion++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
