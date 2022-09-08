int GetMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($" максимальный элемент {max}");
    return max;
}

int GetMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($" минимальный элемент {min}");
    return min;
}

int PrintSum(int max, int min)
{
    int res = max - min;
    return res;
}

Console.Write("Введите кол-во элементов: ");
bool isNum = int.TryParse(Console.ReadLine(), out int num);
if (!isNum)
{
    Console.WriteLine("Еще раз");
    return;
}

Random random = new Random();
int[] array = new int[num];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10); // Тоже ограничил диапазон для быстрой и удобной проверки
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int result = PrintSum(GetMax(array), GetMin(array));
Console.WriteLine($"результат {result}");





















//PrintSum(GetMin(n),GetMax(n));