int GetSum(int n)
{
int sum =0;
while(n>0)
{
    sum = sum + (n%10);
    n=n/10;
   }
   return sum;
}

void PrintSum(int sum)
{
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число");
bool isNum= int.TryParse(Console.ReadLine(), out int n);
if (!isNum)
{
    Console.WriteLine("Попробуй ещё раз ");
    return;
}
PrintSum(GetSum(n));








