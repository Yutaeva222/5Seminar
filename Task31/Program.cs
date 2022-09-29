// Задача 31: Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] arr) // заполнение массива рандомными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] arr) // выведение массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}

int GetSumNegative(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}

int[] GetSums(int[] arr)
{
    int[] sumArray = new int[2] {0, 0}; // [0] - сумма положительных, [1] - сумма отрицательных
    sumArray[0] = 0;
    sumArray[1] = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumArray[0] += arr[i];
        if (arr[i] < 0)
            sumArray[1] += arr[i];
    }
    return sumArray;
}

int LimitedArraySum(int[] array, bool direction, int limit)
{
    int sum = 0;

    if (direction)
    {
        for(int i = 0; i < array.Length; i++)
        
            if (array[i] > limit)
                sum += array[i];
        
    }
    else
    {
        for(int i = 0; i < array.Length; i++)
        
            if (array[i] < limit)
                sum += array[i];
           
        
    }
    return sum;
}
//***********************************
int[] massiv = new int[12];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Сумма положительных чисел: " + GetSumPositive(massiv));
Console.WriteLine("Сумма отрицательных чисел: " + GetSumNegative(massiv));


// int[] OutMassiv = new int[2];
// OutMassiv = GetSums(massiv);
// Console.WriteLine("Сумма положительных: " + OutMassiv[0]);
// Console.WriteLine("Сумма отрицательных: " + OutMassiv[1]);


// Console.WriteLine("Сумма положительных: " + GetSums(massiv)[0]);
// Console.WriteLine("Сумма отрицательных: " + GetSums(massiv)[1]);

// Console.WriteLine("Сумма положительных: " + LimitedArraySum(massiv,true,0));
// Console.WriteLine("Сумма отрицательных: " + LimitedArraySum(massiv,false,0));
