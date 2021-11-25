int Max(int arg1, int arg2, int arg3) // метод поиска максимального из трёх
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} // кусок кода, отвечающий за поиск максимального из трёх
//               0   1   2   3   4   5   6   7   8
int[] array = { 21, 42, 573, 34, 55, 68, 72, 89, 49 };

int max = Max(
    Max(array[0],array[1], array[2]),
    Max(array[3],array[4], array[5]), 
    Max(array[6],array[7], array[8])); // использование метода сравнения
Console.WriteLine(max);