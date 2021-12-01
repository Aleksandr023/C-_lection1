// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача

string text = "— Я думаю, — Сказал князь, улыбаясь, — что, "
            + "ежели бы ваС поСлали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом Согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char OldValue, char NewValue)
{
    string result= String.Empty;

    int length = text.Length;
    for (int i = 0; i<length; i++)
    {
        if(text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}
string NewText = Replace(text, ' ', '|');
//Console.WriteLine(NewText);
//Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');
//Console.WriteLine(NewText);
//Console.WriteLine();
NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);
Console.WriteLine();