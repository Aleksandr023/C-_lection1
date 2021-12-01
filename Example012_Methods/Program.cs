//Type 1 Ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор");
}
//Method1(); //Способ вызова метода

//Tupe 2
void Method2(string msg) // принимает аргументы, ничего не возвращает
{
    Console.WriteLine(msg);
}
//Method2("Message");

void Method21(string msg, int count) // принимает несколько аргументов
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(count: 4, msg:"New Text"); // если использовать именованные аргументы, не обязательно писать их по порядку

//Type 3 ничего не принимают, что-то возвращают
int Method3() //обязательно указывать тип данных которые метод возвращает
{
    return DateTime.Now.Year; // обязательно использовать команду return
}
//int year = Method3(); // нужно ввести переменную которую заполнит метод
//Console.WriteLine(year);

//Type 4 что-то принимает, что-то возвращает
string Method4(int count, string text)//обязательно указывать тип данных которые метод возвращает
{
    int i = 0;
    string result = String.Empty;//String.Empty вкладывает в переменную пустую строку
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "qwerty");
//Console.WriteLine(res);

string Method41(int count, string text)//обязательно указывать тип данных которые метод возвращает
{
    string result = String.Empty;//String.Empty вкладывает в переменную пустую строку
    for(int i=0; i<count; i++)    // используется для лаконичности написания кода, включает в себя переменную, счетчик переменных, увеличение переменной
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwerty");
//Console.WriteLine(res);

for (int i = 2; i <10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); //способ интерполяции строк
    }
    Console.WriteLine();
}