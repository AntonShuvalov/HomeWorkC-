int[,] CreateNewArray(int m, int n)
{
    int num = 1;
    int[,] array = new int[m, n];

    for (int y = 0; y < n; y++)
    {
        array[0, y] = num;
        num++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = num;
        num++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = num;
        num++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = num;
        num++;
    }
    int j = 1;
    int k = 1;
    while (num < m * n)
    {
        while (array[j, k + 1] == 0)
        {
            array[j, k] = num;
            num++;
            k++;
        }
        while (array[j + 1, k] == 0)
        {
            array[j, k] = num;
            num++;
            j++;
        }
        while (array[j, k - 1] == 0)
        {
            array[j, k] = num;
            num++;
            k--;
        }
        while (array[j - 1, k] == 0)
        {
            array[j, k] = num;
            num++;
            j--;
        }
    }
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = num;
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write($"{array[i, j]}  ");
            }
        }
        Console.WriteLine();
    }

}

Console.Write("Введите количесво строк  матрицы: ");
bool isNumM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количесво столбцов матрицы: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int n);


if (!isNumM || !isNumN)
{
    Console.WriteLine("Ошибка");
    return;
}

PrintArray(CreateNewArray(m, n));