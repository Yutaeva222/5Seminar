// Задача 35. Задайте одномерный массив, состоящий из случайных чисел.Найдите кол-во элементов массива, 
// значения которых лежат в отрезке [10,99].

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 99);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int FindCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 100)
        {
            count++;
        }
    }
    return count;
}

int[] massive = new int[12];
FillArray(massive);
PrintArray(massive);
Console.WriteLine("Число элементов в диапозоне от 10 до 99 = " + FindCount(massive));