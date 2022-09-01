int [] GetMass(int n)
{
    int max = 1;
    int cub = 0;
    int[] array = new int[n];
    int index = 0;

    while (max <= n)
    {
        cub = max * max * max;
        array[index] = cub;
        index++;
        max++;
    }
    return array;
}

void PrintMass(int [] array)
{
    int index = 0;
    while(index < array.Length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

Console.Write("Введи число: ");
bool isNum = int.TryParse(Console.ReadLine(), out int n);
if (!isNum)
{
    Console.WriteLine("Попробуй ещё раз ");
}

PrintMass(GetMass(n));


