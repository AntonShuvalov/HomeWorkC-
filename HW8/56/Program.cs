int[,] CreateAndFillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
    return array;
}

int SearchSumInArray(int[,] arr)
{
    int min = 100;
    int saveNum = 0;
    int[] mass = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < min)
        {
            min = sum;
            saveNum = i;
        }
    }
    return saveNum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult(int[,] array, int num)
{
    Console.Write($"Строка с наименьшей суммой элементов: ");
    for (int i = num; i == num; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количесво строк: ");
bool isNumM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количесво столбцов: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumM || !isNumN)
{
    Console.WriteLine("Ошибка");
    return;
}

int[,] mass = CreateAndFillArray(m, n);
PrintArray(mass);
Console.WriteLine();
int resMass = SearchSumInArray(mass);
PrintResult(mass, resMass);


