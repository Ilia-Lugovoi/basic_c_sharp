// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[] limits = {-10, 11};

int[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns, int[] limits)
{
    int[,] twoDimArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            twoDimArray[i, j] = new Random().Next(limits[0], limits[1]);
            Console.Write($"{twoDimArray[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    return twoDimArray;
}

int[,] array = CreateTwoDimArrayOfRandNumbs(rows, columns, limits);

Console.Write("Enter row of your number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter column of your number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(array[m, n] )
{
    Console.WriteLine(array[m,n]);
}
else
{
    Console.WriteLine("No such element");
}
