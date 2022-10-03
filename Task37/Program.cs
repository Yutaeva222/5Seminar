// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний, второй и 
// предпоследний  и т.д. Результат запишите в новом массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
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
int size = 7;
int[] massive = new int[size];
FillArray(massive);
PrintArray(massive);
GetParyProizv(massive);

void GetParyProizv(int[] arr)
{
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{massive[i]} * {massive[maxIndex - i]} = {massive[i] * massive[maxIndex - i]}");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine("Элемент без пары: " + arr[size / 2]);
    }
    Console.WriteLine();
}

