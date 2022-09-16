double[,] CreateAndFillArray(int m, int n)
{
    Random random = new Random();
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (double)random.Next(-100, 101) / 10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.Write("Введите количесво строк: ");
bool isNumM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количесво столбцов: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumM || !isNumN)
{
    Console.WriteLine("Ошибка");
    return;
}

PrintArray(CreateAndFillArray(m, n));