Console.Write("Enter the number of Fibonacci numbers: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c;

Console.Write(a + " " + b + " ");

for (int i = 2; i < n; i++)
{
    c = a + b;
    a = b;
    b = c;

    Console.Write(c + " ");
}

Console.WriteLine();
