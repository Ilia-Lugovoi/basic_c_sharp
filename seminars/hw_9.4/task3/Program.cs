// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int СalculateAckermannFunc(int m, int n)
{
    if(m < 0 || n < 0) return 0;
    else
    {
        if (m == 0) return n + 1;
        if (m != 0 && n == 0) return СalculateAckermannFunc(m - 1, 1);
        if (m > 0 && n > 0) return СalculateAckermannFunc(m - 1, СalculateAckermannFunc(m, n - 1));
        return СalculateAckermannFunc(m, n);
    }
}

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = СalculateAckermannFunc(Prompt("Enter number M: "), Prompt("Enter number N: "));

if(sum == 0) Console.WriteLine("Numbers must be positive");
else Console.WriteLine($"Ackermann function value: {sum}");

