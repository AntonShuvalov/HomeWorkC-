void PrintNumber(int a, int b)
{
    if (a > b) return;
    Console.Write($"{a} ");
    PrintNumber(a + 1, b);
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

PrintNumber(a, b);


