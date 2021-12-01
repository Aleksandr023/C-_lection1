int[] arr = { 1, 5, 2, 9, 4, 6, 3, 1, 1 };

void PrintArray(int[] array) // метод вывода массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); // выводит элемент массива
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // сортировка массива от минимального к максимальному значению
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;// индекс минимального значения
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // если элемент массива с индексом j меньше элемента массива с индексом minPosition в minPosition записывается j
        }
        int temp = array[i]; // элемент массива с индексом i записывается во временную переменную
        array[i] = array[minPosition];// в элемент массива с индексом i перемещается минимальный элемент массива
        array[minPosition] = temp;// в минимальную позицию записывается элемент из временной переменной

    }
    }
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);