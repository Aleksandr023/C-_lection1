int[] array = { 1, 12, 35, 77, 41, 15, 96, 77, 28 };

int n = array.Length; // возвращает длину (количество элементов) массива
int find = 77;
int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливает выполнение алгоритма при получении результата
    }
    index++; // == index + 1
}