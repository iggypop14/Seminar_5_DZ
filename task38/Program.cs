// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// Random rand = new Random();
// double number = Math.Round(rand.Next(0,10) + rand.NextDouble(), 3);
// System.Console.WriteLine(number);
double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
    }
    return tempArray;
}
void PrintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void F_min(double[] array, out double min)
{
    min = array[0];
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
    }
}
void F_max(double[] array, out double max)
{
    max = array[0];
    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] > max) max = array[j];
    }
}
//----------------------------------------------------------------------------------
double[] array = FillArray(20, -99, 99);
PrintArray(array);
F_min(array, out double min);
System.Console.WriteLine($" Минимальный элемент массива: {min}");
F_max(array, out double max);
System.Console.WriteLine($" Максимальный элемент массива: {max}");
System.Console.WriteLine($" Разница между максимальным и минимальным элементами массива: {max - min}");
