int GetWeek(int num)
{
    if (num == 6 || num == 7)
    {
        return 1;
    }
    if (num > 7 || num < 1)
    {
        return -1;
    }
    else
    {
        return 0;
    }
}

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = GetWeek(num);
if (res == 1)
{
    Console.WriteLine("Да");
}
if (res == -1)
{
    Console.WriteLine("Попробуй еще раз");
}
if (res == 0)
{
    Console.WriteLine("Нет");
}