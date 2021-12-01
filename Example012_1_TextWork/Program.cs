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

string Replace(string text, char OldValue, char NewValue) // Метод замены знаков в тексте
{
    string result= String.Empty;

    int length = text.Length; // определение количества символов
    for (int i = 0; i<length; i++) // i - порядковый номер символа в тексте
    {
        if(text[i] == OldValue) result = result + $"{NewValue}"; // описание: если элемент текста имеет старое значение, то в результат записывается новое значение
        else result = result + $"{text[i]}"; // в другом случае в результат идет текущий символ
    }


    return result;
}
string NewText = Replace(text, ' ', '|'); //вводим переменную в которой применяем метод замены значений элементов
//Console.WriteLine(NewText);
//Console.WriteLine();
NewText = Replace(NewText, 'к', 'К'); // в переменной применяем метод еще раз
//Console.WriteLine(NewText);
//Console.WriteLine();
NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);
Console.WriteLine();