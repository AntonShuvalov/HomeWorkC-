int GetSummNumber(int a, int b)
{
    if (a < b)
    {
        return a + GetSummNumber(a + 1, b);
    }
    else
    {
        return a;
    }
}

Console.Write("Введите первое число: ");
bool isNumA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите второе число: ");
bool isNumB = int.TryParse(Console.ReadLine(), out int b);

if (!isNumA || !isNumB)
{
    Console.WriteLine("Ошибка");
    return;
}

Console.WriteLine(GetSummNumber(a, b));