int GetNum(int num)
{
    if (num < -99 && num > -1000 || num > 99 && num < 1000)
    {
        int res1 = num % 100;
        if (res1 < 0)
        {
            res1 = res1 * -1;
        }
        int res2 = res1 / 10;
        num = res2;
        return num;
    }
    else
    {
        num = 0;
    }
    {
        return num;
    }
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = GetNum(num);

if (result == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    Console.WriteLine(result);
}
