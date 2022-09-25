int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}

Console.Write("Введите первое число: ");
bool isNumM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumM || !isNumN)
{
    Console.WriteLine("Ошибка");
    return;
}
if (m < 0 || n < 0)
{
    Console.WriteLine("C этими числами работать не будет");
    return;
}

Console.WriteLine(FunctionAkkerman(m, n));