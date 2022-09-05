void GetMas(int n, int num)
{
    int[] mas = new int[n];
    int i = 0;
    mas[i] = num;
    while (i < mas.Length)
    {
        Console.Write($"{mas[i]}");
        i++;
        break;
    }
}

Console.Write("Введите кол-во элементов: ");
bool isNum1 = int.TryParse(Console.ReadLine(), out int n);
if(n<=0)
{
    Console.WriteLine("Попробуй ещё раз ");
    return;
}
Console.WriteLine("Введите элементы без пробелов: ");
bool isNum2 = int.TryParse(Console.ReadLine(), out int num);

if (!isNum1 || !isNum2 )
{
    Console.WriteLine("Попробуй ещё раз ");
    return;
}
GetMas(n, num);


