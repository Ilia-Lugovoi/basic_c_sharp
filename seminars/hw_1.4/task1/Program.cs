// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 5, b = 7;
int max = a;
int min = b;

if(b > max)
{
    max = b;
    min = a;
}

Console.Write("Большее: ");
Console.WriteLine(max);

Console.Write("Меньшее: ");
Console.WriteLine(min);

a = 2;
b = 10;
max = a;
min = b;

if(b > max)
{
    max = b;
    min = a;
}

Console.Write("Большее: ");
Console.WriteLine(max);

Console.Write("Меньшее: ");
Console.WriteLine(min);

a = -9;
b = -3;
max = a;
min = b;

if(b > max)
{
    max = b;
    min = a;
}

Console.Write("Большее: ");
Console.WriteLine(max);

Console.Write("Меньшее: ");
Console.WriteLine(min);
