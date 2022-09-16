int[,] CreateAndPrintArray()
{
    Random random = new Random();
    int[,] array = new int[4, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

double[] CalculateResult(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }
        result[j] = sum / array.GetLength(1);
    }
    return result;
}

void PrintResult(double[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"[{result[i]}] ");
    }
    Console.WriteLine();
}

PrintResult(CalculateResult(CreateAndPrintArray()));