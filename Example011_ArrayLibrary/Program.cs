void FillArray(int[] collection) // метод для наполнения массива элементами
{
    int length = collection.Length; // определяет длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // генерирует случайное число в массив
        index++;
    }

}

void PrintArray(int[] col) // метод вывода массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод нахождения индекса элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 будет выводиться, если заданного элемента в массиве нет
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position; // возвращает номер элемента массива
}

int[] array = new int[10]; // new int[10] - создает новый массив с заданным числом элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 55);
Console.WriteLine(pos);