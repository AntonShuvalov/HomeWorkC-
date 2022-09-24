int[,,] CreateAndFill3DArray(int[] mass, int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    int f = 0;
    while (f < mass.Length)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = mass[f];
                    f++;
                }
            }
        }
    }
    return array;
}

int[] CreateRandomStringArray(int a, int b, int c)
{
    int sum = a * b * c;
    int[] mass = new int[sum];
    Random random = new Random();
    int y = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = random.Next(10, 100);
        y = mass[i];
        for (int j = 0; j < i; j++)
        {
            while (mass[i] == mass[j])
            {
                mass[i] = random.Next(10, 100);
                j = 0;
                y = mass[i];
            }
            y = mass[i];
        }
    }
    return mass;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количесво строк  матрицы: ");
bool isNumA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите количесво столбцов  матрицы: ");
bool isNumB = int.TryParse(Console.ReadLine(), out int b);
Console.Write("Введите количесво рядов матрицы: ");
bool isNumC = int.TryParse(Console.ReadLine(), out int c);

if (!isNumA || !isNumB || !isNumC)
{
    Console.WriteLine("Ошибка");
    return;
}
if (a * b * c > 90)
{
    Console.WriteLine("Такую матрицу мы составлять не будем");
    return;
}

int[] number = CreateRandomStringArray(a, b, c);
int[,,] result = CreateAndFill3DArray(number, a, b, c);
PrintArray(result);

