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

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;

    }
    }
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);