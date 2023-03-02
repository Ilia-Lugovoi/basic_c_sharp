// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int IntNumberRequest(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double DoubNumberRequest(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

void Main(string[] args)
{
    int m = IntNumberRequest("Enter number of numbers: ");
    int count = 0;
    for (int i = 0; i <= m; i++)
    {
        double num = DoubNumberRequest($"Enter number {i}: ");
    }

    if(num > 0)
    {
        count++;
    }
}

Console.WriteLine($"Numbers greater than zero: {count}");
