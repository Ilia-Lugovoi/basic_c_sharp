// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = num + 1;
int[] numbs = new int[newNum];

Console.Write($"{num} -> ");
for (int i = 1; i < numbs.Length; i++)
{
    numbs[i] = i;
    Console.Write($"{Math.Pow(numbs[i], 3)} ");
}

Console.WriteLine();
