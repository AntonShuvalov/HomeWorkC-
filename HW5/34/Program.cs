int GetArray(int n)
{
    Random random = new Random();
    int[] array = new int[n];
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        Console.WriteLine(array[i]);
        if (array[i] % 2 == 0)
            res = res + 1;

    }
    return res;
}

void PrintPes(int res)
{
    Console.WriteLine(res);
}

Console.Write("Введите кол-во элементов: ");
bool isNum = int.TryParse(Console.ReadLine(), out int n);
if (!isNum)
{
    Console.WriteLine("Еще раз");
    return;
}

PrintPes(GetArray(n));

