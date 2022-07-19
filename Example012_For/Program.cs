//Вид 4 методов (что-то принимают, что-то возвращают)

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = ""; // = string.Empty;
    
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;

// }

string Method4(int count, string text)
{
    string result = ""; // = string.Empty;
    
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;

}

string res = Method4(4, "Текст");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}