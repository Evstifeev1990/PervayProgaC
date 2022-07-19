//Раборта с текстом
//Дан текст. В тексте нужно все проблемы заменить черточками
// Маленькие буквы "к" заменить большими "К"
//большие "С" заменить маленькими "c"

string text = "Я думаю, - сказал князь улыбаясь, - что, "
            + "ежели бы вас послали вместо вместо нашего милого Винцегероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int dlinaStroki = text.Length;
    
    for (int i = 0; i < dlinaStroki; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
                else result = result + $"{text[i]}";
        }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);