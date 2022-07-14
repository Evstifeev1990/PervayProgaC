int[] array = { 12, 23, 35, 42, 53, 35, 72, 85, 96 };

int n = array.Length;

int fide = 35;

int index = 0;

while(index<n)
{
    if(array[index] == fide)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}