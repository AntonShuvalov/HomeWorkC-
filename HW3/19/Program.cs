bool Pal(int n)
{
    int n1 = n / 10000;
    int n2 = (n / 1000) % 10;
    int n4 = (n / 10) % 10;
    int n5 = n % 10;

    if (n1 == n5 && n2 == n4)
    {
        return true;
    }
    return false;
}

Console.Write("Введите число: ");
bool res1 = int.TryParse(Console.ReadLine(), out int n);
bool res = Pal(n);

if (!res1 || (n <10000  && n > -10000  ) || n> 99999 || n<-99999)
{
    Console.WriteLine("Ещё раз ");
    return;
}
if (res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}












