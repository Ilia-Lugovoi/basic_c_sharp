// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int n = Prompt("Enter number pls: ");

void DerivationNaturalNumbsFromN(int n)
{
    if(n != 0)
    {
        Console.Write($"{n} ");
        DerivationNaturalNumbsFromN(n - 1);
    }
}

DerivationNaturalNumbsFromN(n);

Console.WriteLine();
