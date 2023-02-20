// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number = 5;
int i = 1;

while(i <= number)
{
    if(i % 2 == 0)
    {
        Console.Write(i);
        if(i != number & i != number - 1)
        {
            Console.Write(", ");
        }
    }
    i++;
}

Console.WriteLine();

number = 8;
i = 1;
while(i <= number)
{
    if(i % 2 == 0)
    {
        Console.Write(i);
        if(i != number & i != number - 1)
        {
            Console.Write(", ");
        }
    }
    i++;
}

Console.WriteLine();
