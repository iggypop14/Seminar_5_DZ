// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("\n\nЗадан массив:\n " + "[" + string.Join(", ", arrayForPrint) + "]");
}

void FindSumChPosition(int[] tempArray, out int sumChPosition)
{
    sumChPosition = 0;
    for (int i = 1; i < tempArray.Length; i+=2)
    {
        sumChPosition += tempArray[i]; // sumPositive = sumPositive + array[i]
    }
}

// ---------------------------------------------------------------------------

int[] array = FillArray(4, -99, 99);
PrintArray(array);
FindSumChPosition(array, out int sumChPosition);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива равна: {sumChPosition}\n");