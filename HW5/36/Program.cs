// За нечетную позицию я принял нечетный индекс массива (как в образце домашнего задания)


int GetMas(int n)
{
    Random random = new Random();
    int[] array = new int[n];
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10); // Специально ограничил диапазон для быстрой и удобной проверки!
        Console.WriteLine(array[i]);
        if (i % 2 != 0)
            res = res + array[i];

    }
    return res;
}

void PrintSum(int res)
{
    Console.WriteLine();
    Console.WriteLine($"Результат = {res}");
}

Console.Write("Введите кол-во элементов: ");
bool isNum = int.TryParse(Console.ReadLine(), out int n);
if (!isNum)
{
    Console.WriteLine("Еще раз");
    return;
}

PrintSum(GetMas(n));