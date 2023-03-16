// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 (4, 5, 6, 7, 8)

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Enter number M pls: ");
int n = Prompt("Enter number N pls: ");
int sum = 0;

int FindSumFromMToN(int a, int b, int sum)
{
    if(a > b) return sum;
    {
        Console.Write($"{a} ");
        sum += a;
        return FindSumFromMToN(a + 1, b, sum);
    }
}

sum = FindSumFromMToN(m, n, sum);
Console.WriteLine($"Sum: {sum}");
