int[] numbers = { 11, 83, 18, 94, 19, 46, 83, 37, 24, 64, 48, 55 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void MaxMinSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}
PrintArray(numbers);
MaxMinSort(numbers);

PrintArray(numbers);