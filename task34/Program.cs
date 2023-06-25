// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//--------------------------------- Написание функций ------------------------------------------
int[] FillArray(int size, int leftRange, int rightRange) // Функция заполнения массива
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange);
    }
    return tempArray;
}

void FindCh(int[] tempArray, out int how_many_Ch) // Функция подсчёта чётных числе в массиве
{
    how_many_Ch = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i]%2 == 0)
        {
           how_many_Ch++; 
        }
    }
}
void PrintArray(int[] arrayForPrint) // Функция вывода массива
{
    System.Console.WriteLine("\n\nЗадан массив:\n " + "[" + string.Join(", ", arrayForPrint) + "]");
}
// --------------------------------- Написание кода ------------------------------------------

int[] array = FillArray(20, 100, 1000);
FindCh(array, out int how_many_Ch);
PrintArray(array);
System.Console.WriteLine($"\nКоличество чётных чисел в массиве: {how_many_Ch}\n");

