// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 3;
int columns = 4;
int[] limits = {0, 11};

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

double averageOfColumn = 0;
while(columns > 0)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, columns - 1];
    }
    averageOfColumn = Math.Round((Convert.ToDouble(sum) / Convert.ToDouble(rows)), 2);
    columns--;
    Console.WriteLine($"Average of column {columns + 1}: {averageOfColumn}");
}

