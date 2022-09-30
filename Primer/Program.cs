int GetMulti(int a, int b)
{
    return a*b;
}

Console.WriteLine("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Произведение чисел А и В = " + GetMulti(num1, num2));
