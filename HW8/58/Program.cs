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

int[,] CalculateResultTwoArray(int[,] array1, int[,] array2)
{
    int[,] resArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                resArray[i, k] += array1[i, j] * array2[j, k];
            }
        }
    }
    return resArray;
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

Console.Write("Введите количесво строк первой матрицы: ");
bool isNumA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите количесво столбцов первой матрицы: ");
bool isNumB = int.TryParse(Console.ReadLine(), out int b);

Console.Write("Введите количесво строк второй матрицы: ");
bool isNumM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количесво столбцов второй матрицы: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumA || !isNumB || !isNumM || !isNumN)
{
    Console.WriteLine("Ошибка");
    return;
}
if (b != m)
{
    Console.WriteLine("Такие матрицы нельзя умножить");
    return;
}

int[,] array1 = CreateAndFillArray(a, b);
int[,] array2 = CreateAndFillArray(m, n);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] result = CalculateResultTwoArray(array1, array2);
PrintArray(result);