// Задача 35.
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
//[5, 18, 123, 6, 2] ->

//------------------------------------------ Создание функций --------------------------------------------
int[] FillArray()
{
    int[] tempArray = new int[123];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(10, 100);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("\n\nЗадан массив:\n " + "[" + string.Join(", ", arrayForPrint) + "]\n");
}

int Sum_Ten_NN(int[] tempArray)
{
    int j = 0;
    for (int i = 0; i < tempArray.Length && tempArray[i] > 10 && tempArray[i] < 99; i++)
    {
        System.Console.WriteLine($"Число в диапазоне от 10 до 99 равно: {tempArray[i]}");
        j++;
    }
    return j;
}
// Написание кода
int[] array = FillArray();
PrintArray(array);
int num = Sum_Ten_NN(array);
System.Console.WriteLine($"\nКоличество значений элементов массива в диапазоне от 10 до 99 равно: {num}");

