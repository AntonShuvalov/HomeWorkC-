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

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             for (int f = j+1; f < arr.GetLength(1); f++)
            {
                int max ;
                if (arr[i, j ] < arr[i, f])
                {
                    max = arr[i, j];
                    arr[i, j] = arr[i, f];
                    arr[i, f] = max;
                }
            }
        }
    }
    return arr;
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
int[,] resMass = SortArray(mass);
PrintArray(resMass);