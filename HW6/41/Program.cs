// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
# nullable disable
int[] FillArray()
{
    Console.WriteLine("Введите числа через запятую: ");
    string number = Console.ReadLine();
    string[] array = number.Split(",");
    int[] newArray = new int[array.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Convert.ToInt32(array[i]);
    }
    return newArray;
}

int CountNumberInArray(int[] newArray)
{
    int result = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) result++;
    }
    return result;
}

void PrintResult(int result)
{
    Console.WriteLine($"-----> {result}");
}

PrintResult(CountNumberInArray(FillArray()));

