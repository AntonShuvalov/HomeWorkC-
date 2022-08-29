int GetNum(int num)
{
    if (num < 100 && num > -100)
    {
        num = 0;
        return num;
    }
    else
    {
        while (num > 999 || num < -999)
        {
            num = num / 10;
        }
        num = num % 10;
        if (num < 0)
        {
            num = num * -1;
        }
        return num;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = GetNum(num);

if (result == 0)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine(result);
}


















