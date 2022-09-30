// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и
// наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    // Console.WriteLine();
}
void ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= -1;            
        }
}
Console.WriteLine("Введите число элементов массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array);
PrintArray(array);
ChangeArray(array);
Console.WriteLine("\n");
PrintArray(array);

