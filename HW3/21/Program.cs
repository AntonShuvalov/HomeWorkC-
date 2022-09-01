double GetDot(int a1, int a2, int a3, int b1, int b2, int b3)
{
    return Math.Sqrt((b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2) + (b3 - a3) * (b3 - a3));
}

Console.Write("Введите первую координату точки A: ");
bool isDotA1 = int.TryParse(Console.ReadLine(), out int a1);
Console.Write("Введите вторую координату точки A: ");
bool isDotA2 = int.TryParse(Console.ReadLine(), out int a2);
Console.Write("Введите третью координату точки A: ");
bool isDotA3 = int.TryParse(Console.ReadLine(), out int a3);
Console.Write("Введите первую координату точки B: ");
bool isDotB1 = int.TryParse(Console.ReadLine(), out int b1);
Console.Write("Введите вторую координату точки B: ");
bool isDotB2 = int.TryParse(Console.ReadLine(), out int b2);
Console.Write("Введите третью координату точки B: ");
bool isDotB3 = int.TryParse(Console.ReadLine(), out int b3);

if (!isDotA1 || !isDotA2 || !isDotA3 || !isDotB1 || !isDotB2 || !isDotB3)
{
    Console.WriteLine("Ещё раз");
    return;
}
double res = GetDot(a1, a2, a3, b1, b2, b3);
Console.WriteLine(res);