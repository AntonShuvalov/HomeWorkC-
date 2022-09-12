// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] CalculateResult(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintResult(double[] array)
{
    Console.Write($"Точка пересечения (");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"{array[i]}; ");
        }
        else
        {
            Console.WriteLine($"{array[i]})");
        }
    }
}

Console.Write("b1 = ");
bool isNumB1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("k1 = ");
bool isNumK1 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("b2 = ");
bool isNumB2 = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("k2 = ");
bool isNumK2 = double.TryParse(Console.ReadLine(), out double k2);

if (!isNumB1 || !isNumK1 || !isNumB2 || !isNumK2)
{
    Console.WriteLine("Попробуй ещё раз ");
    return;
}
if (k1 - k2 == 0)
{
    Console.WriteLine("Прямые параллельны и не пересекаются");
    return;
}
double[] result = CalculateResult(b1, k1, b2, k2);
PrintResult(result);