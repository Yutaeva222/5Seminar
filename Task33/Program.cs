// : Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,20);
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

void CheckArray (int[] arr, int check)
{
    bool flag = false;
    // for (int i = 0; i < arr.Length; i++)
    // {
    //   if (check == arr[i])
    //     flag = true;
    // }
    // if(flag = true)
    //   Console.WriteLine("ДА, это число есть в массиве"); 
    // else 
    //   Console.WriteLine("НЕТ, этого числа нет в массиве"); 
    
    int i = 0;
    while (!flag && i < arr.Length)
    {
        if (check == arr[i])
        {
            flag = true;
        }
        i++;
    }
    if (flag)
    {
        Console.WriteLine("ДА, это число есть в массиве");
    }
    else
    {
        Console.WriteLine("НЕТ, этого числа нет в массиве!");
    }

}

Console.Clear();
Console.WriteLine("Введите число для поиска в массиве! ");
int check = Convert.ToInt32(Console.ReadLine());
int[] massive = new int [12];
FillArray(massive);
PrintArray(massive);
CheckArray(massive, check);


