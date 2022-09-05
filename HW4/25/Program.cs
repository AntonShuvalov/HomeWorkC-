int GetStep(int n1, int n2)
{
    int i = 0;
    int step = 1;
    while (i < n2)
    {
        step = step * n1;
        i++;
    }
    return step;
}
void PrintStep(int step)
{
    Console.WriteLine(step);
}

Console.Write("Введи число A: ");
bool isNum1 = int.TryParse(Console.ReadLine(), out int n1);
Console.Write("Введи число B: ");
bool isNum2 = int.TryParse(Console.ReadLine(), out int n2);
if (!isNum1 || !isNum2 || n2 < 0)
{
    Console.WriteLine("Попробуй ещё раз ");
    return;
}
PrintStep(GetStep(n1, n2));

