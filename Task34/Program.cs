// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99,1000);
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

int CountChet(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {   if (arr[i] % 2 == 0)
          count = count + 1;
    }
    return count;
}

int[] massiv = new int[8];
FillArray(massiv);
PrintArray(massiv);
int result = CountChet(massiv); 
Console.WriteLine("Число четных числе в массиве = " + CountChet(massiv));
