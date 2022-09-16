int[,] CreateNewArray() // создает массив и передает на печать
{
    Random random = new Random();
    int[,] array = new int[4, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // печатает массив
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

int[] SearchIndexInArray(int[,] array, int num) // ищет число  и передает результат
{
    int[] resArray = new int[2];
    resArray[0] = -1;
    resArray[1] = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                resArray[0] = i;
                resArray[1] = j;
                break;
            }
        }
    }
    return resArray;
}

void PrintIndex(int[] resArray) //принимает и печатает результат
{
    if (resArray[0] == -1 )
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine($"Индеск заданного числа: [{resArray[0]},{resArray[1]}] ");
    }
}
int[,] mass = CreateNewArray();
PrintArray(mass);
Console.Write("Введите число для поиска: ");
bool isNum = int.TryParse(Console.ReadLine(), out int num);

if (!isNum)
{
    Console.WriteLine("Ошибка");
    return;
}

int[] result = SearchIndexInArray(mass, num);
PrintIndex(result);


