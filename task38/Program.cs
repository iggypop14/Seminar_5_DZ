// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// Random rand = new Random();
// double number = Math.Round(rand.Next(0,10) + rand.NextDouble(), 3);
// System.Console.WriteLine(number);
int[] arr = { 5, 120, 4, 3, 2, 6, 7, 100, 10 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0 ; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void F_min(int[] array, out int min)
{
min = arr[0];
{
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    //return min;
}
}
void F_max(int[] array, out int max)
{
    max = arr[0];
    for(int j = 1; j < array.Length; j++)
    {
        if(array[j] > max) max = array[j];
    }
    //return max;
}

//----------------------------------------------------------------------------------
PrintArray(arr);
//int min = arr[0];
F_min(arr, out int min);
System.Console.WriteLine($" Минимальный элемент массива: {min}");
//int max = 0;
F_max(arr, out int max);
System.Console.WriteLine($" Максимальный элемент массива: {max}");
