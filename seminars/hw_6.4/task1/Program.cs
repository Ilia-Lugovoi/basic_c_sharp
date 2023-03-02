// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int IntNumberRequest(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountPositiveNumbers()
{
    int m = IntNumberRequest("Enter number of numbers: ");
    int count = 0;
    for (int i = 1; i <= m; i++)
    {
        int num = IntNumberRequest($"Enter number {i}: ");
        if(num > 0)
        {
            count++;
        }
    }

    return count;
}

int count = CountPositiveNumbers();

Console.WriteLine($"Numbers greater than zero: {count}");
